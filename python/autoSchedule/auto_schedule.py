import time
import typing
from datetime import datetime
from selenium import webdriver
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.common.by import By
from selenium.webdriver.support import expected_conditions as EC
import requests
from courses import Course, Lesson, Hour, Combination, Curriculum
from itertools import product
import statistics
import argparse


BANNER = """

                _           _____      _              _       _      
     /\        | |         / ____|    | |            | |     | |     
    /  \  _   _| |_ ___   | (___   ___| |__   ___  __| |_   _| | ___ 
   / /\ \| | | | __/ _ \   \___ \ / __| '_ \ / _ \/ _` | | | | |/ _ \\
  / ____ \ |_| | || (_) |  ____) | (__| | | |  __/ (_| | |_| | |  __/
 /_/    \_\__,_|\__\___/  |_____/ \___|_| |_|\___|\__,_|\__,_|_|\___|
                                                                     
                                                                                                                           
                __  __                     ______                __ 
                \ \/ /___  ____ __   __   / ____/________  _____/ /_
                 \  / __ \/ __ `/ | / /  / __/ / ___/ __ \/ ___/ __/
                 / / /_/ / /_/ /| |/ /  / /___/ /  / / / (__  ) /_  
                /_/\____/\__,_/ |___/  /_____/_/  /_/ /_/____/\__/  
                                                                    
"""


SEMESTERS = {'סמסטר א': 1, 'סמסטר ב': 2}
DAYS = {"יום א'": 1, "יום ב'": 2, "יום ג'": 3, "יום ד'": 4, "יום ה'": 5}
TIME_FORMAT = "%H:%M"
DAYS_IN_WEEK = 5

NOT_BEFORE = "8:00"  # the hour that the day starts
NOT_AFTER = "18:00"  # the hour that the day ends
NOT_BEFORE = datetime.strptime(NOT_BEFORE, TIME_FORMAT)
NOT_AFTER = datetime.strptime(NOT_AFTER, TIME_FORMAT)
CONFLICT_FACTOR = 50  # the higher the factor is, the fewer conflicts between lesson
DISTRIBUTION_FACTOR = 4  # the higher the factor is, the more the hours are distributed in the week
DAYS_FACTOR = 7  # the higher the factor is, the fewer days of learning
START_AT_FACTOR = 1  # the higher the factor is, the more the lessons don't start before the NOT_BEFORE hour
END_AT_FACTOR = 1  # the higher the factor is, the more the lessons don't end after the NOT_AFTER hour
TIME_GAP_FACTOR = 2  # the higher the factor is, the more the lessons are close to each other

CONFLICT_DEBUG = 0
BEST_CONFLICT = 0


def get_courses(courses: typing.Set['int'], year: int, semester_chosen: int) -> typing.List['Course']:
    """ pull the chosen courses from the digmi website, analyze the data, and returns a list of Course objects
    :param courses: a set of course ids
    :param year: the year of the courses
    :return: a list of Course objects"""
    headers = {
        'Accept': 'application/json',
        'Accept-Encoding': 'gzip, deflate, br',
        'Accept-Language': 'en-US,en;q=0.9,he;q=0.8,he-IL;q=0.7',
        'Referer': 'https://www.digmi.org/huji/',

        'User-Agent': 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36',
        'X-Requested-With': 'XMLHttpRequest'
    }
    course_list = []
    for course in courses:
        url = f'https://www.digmi.org/huji/get_course.php?year={year}&course={course}'
        response = requests.get(url, headers=headers)
        if response.status_code == 200:
            data = response.json()
            course_id = int(data['id'])
            course_name = data['name']
            lesson_list = []
            for lesson in data['lessons']:
                not_semester_chosen = False
                lesson_id = lesson['id']
                lesson_teacher = lesson['teacher']
                lesson_type = lesson['type']
                hour_list = []
                for hour in lesson['hours']:
                    semester = SEMESTERS[hour['semester']]
                    # only saves the lessons of the semester chosen and checks if the lesson have a day variable
                    if semester != semester_chosen or hour['day'] == "&nbsp;":
                        not_semester_chosen = True
                        break
                    day = DAYS[hour['day']]
                    end, start = hour['hour'].split('-')
                    end = datetime.strptime(end, TIME_FORMAT)
                    start = datetime.strptime(start, TIME_FORMAT)
                    new_hour = Hour(hour['id'], semester, day, start, end)
                    hour_list.append(new_hour)
                if not not_semester_chosen:
                    lesson_list.append(Lesson(lesson_id, lesson_teacher, lesson_type, hour_list))
            course_list.append(Course(course_id, course_name, lesson_list))
        else:
            print(f"Error: {response.status_code}")
            return []
    return course_list


def combination_conflict(combination1: Combination, combination2: Combination) -> int:
    """ returns the number of conflicts between two combinations
    :param combination1: a Combination object
    :param combination2: a Combination object
    :return: the number of conflicts between the two combinations"""
    conflicts = 0

    for lesson1 in combination1.lesson_tup:
        for lesson2 in combination2.lesson_tup:
            if lesson1 is not None and lesson2 is not None:
                conflicts += conflict_counter((lesson1, lesson2))

    return conflicts


def calculate_score(combination_tup: typing.Tuple['Combination']) -> float:
    """ calculates the score of a given combination of courses (- system)
    :param combination_tup: a tuple of Combination objects - every combination represents a course
    :return: the score of the combination - the score of the system"""
    sec_in_hour = 3600
    hours_over_day = 11
    learning_days = set()
    conflict_score = 0
    global CONFLICT_DEBUG
    hours_list = [0, 0, 0, 0, 0]
    time_gap = 0
    lesson_hours = {}
    start_at = 0
    end_at = 0

    for combination in combination_tup:
        for lesson in combination.lesson_tup:
            if lesson:
                for hour in lesson.hours:
                    hours_per_day = (hour.end - hour.start).seconds / sec_in_hour
                    hours_list[hour.day - 1] += hours_per_day
                    learning_days.add(hour.day)
                    if hour.day not in lesson_hours:
                        lesson_hours[hour.day] = []
                    lesson_hours[hour.day].append((hour.end, hour.start))

    for i in range(len(combination_tup)):
        for j in range(i + 1, len(combination_tup)):
            conflict_score += combination_conflict(combination_tup[i], combination_tup[j])
    for key in lesson_hours:
        lesson_hours[key] = sorted(lesson_hours[key], key=lambda x: x[0])
        if lesson_hours[key][0][1] <= NOT_BEFORE:
            start_at += 1
        if lesson_hours[key][-1][0] >= NOT_AFTER:
            end_at += 1
        for i in range(len(lesson_hours[key]) - 1):
            curr_gap = max(((lesson_hours[key][i + 1][1] - lesson_hours[key][i][0]).seconds / sec_in_hour), 0)
            if curr_gap > hours_over_day:
                curr_gap = 0
            time_gap += curr_gap

    std_dev = statistics.stdev(hours_list)
    score = -(std_dev * DISTRIBUTION_FACTOR) - (len(learning_days) * DAYS_FACTOR) - (
            conflict_score * CONFLICT_FACTOR) - (
                    time_gap * TIME_GAP_FACTOR) - (start_at * START_AT_FACTOR) - (end_at * END_AT_FACTOR)
    CONFLICT_DEBUG = conflict_score
    return score


def choose_best_schedule(courses_combination_dict: typing.Dict[int, typing.List['Combination']]) -> Curriculum:
    """ returns the best schedule from all the possible combinations
    :param courses_combination_dict: a dictionary of all the possible combinations for every course, the key is the course id
     and the value is a list of Combination objects - represents all the possible combinations for a specific course
     :return: the best schedule - a Curriculum object that represents the best system and the score of it"""

    global BEST_CONFLICT
    all_combinations = product(*(course_combination for course_combination in courses_combination_dict.values()))
    first_comb = next(all_combinations, None)
    best_comb = Curriculum(first_comb, calculate_score(first_comb))
    BEST_CONFLICT = CONFLICT_DEBUG
    for comb in all_combinations:
        score = calculate_score(comb)
        if score > best_comb.score:
            best_comb = Curriculum(comb, score)
            BEST_CONFLICT = CONFLICT_DEBUG
    return best_comb


def conflict_counter(lessons: typing.Tuple['Lesson', ...]) -> int:
    """ returns the number of conflicts between unknown number of lessons
    :param lessons: a tuple of Lesson objects
    :return: the number of conflicts between the lessons"""
    num_lessons = len(lessons)
    conflict_sum = 0
    if num_lessons < 2:
        return False

    for i in range(num_lessons):
        for j in range(i + 1, num_lessons):
            lesson1, lesson2 = lessons[i], lessons[j]

            for hour1 in lesson1.hours:
                for hour2 in lesson2.hours:
                    if hour1.day == hour2.day:
                        if hour1.start < hour2.end and hour2.start < hour1.end:
                            conflict_sum += 1

    return conflict_sum


def conflict(lessons: typing.Tuple['Lesson', ...]) -> bool:
    """ returns True if there is a conflict between unknown number of lessons, else False
    :param lessons: a tuple of Lesson objects
    :return: True if there is a conflict between the lessons, else False"""
    num_lessons = len(lessons)

    if num_lessons < 2:
        return False

    for i in range(num_lessons):
        for j in range(i + 1, num_lessons):
            lesson1, lesson2 = lessons[i], lessons[j]

            for hour1 in lesson1.hours:
                for hour2 in lesson2.hours:
                    if hour1.day == hour2.day:
                        if hour1.start < hour2.end and hour2.start < hour1.end:
                            return True

    return False


def create_combinations(course_list: typing.List['Course']) -> typing.Dict[int, typing.List['Combination']]:
    """ returns a dictionary of all the possible combinations for every course, the key is the course id
     and the value is a list of Combination objects - represents all the possible combinations for a specific course
     :param course_list: a list of Course objects
     :return: a dictionary of all the possible combinations for every course"""
    courses_combination_dict = {}
    for course in course_list:
        combination_dict = {}
        combination_list = []
        for lesson in course.lessons:
            if lesson.type not in combination_dict:
                combination_dict[lesson.type] = []
            combination_dict[lesson.type].append(lesson)
        all_combinations = product(*(lessons_combination for lessons_combination in combination_dict.values()))
        for combination in all_combinations:
            if not conflict(combination):
                combination_list.append(Combination(course.id, combination))
        courses_combination_dict[course.id] = combination_list

    return courses_combination_dict


def showing_results(best_comb: Curriculum, year: int) -> None:
    """ showing the best schedule in the Digmi website
    :param best_comb: the best schedule - a Curriculum object that represents the best system and the score of it
    :return: None"""

    try:
        driver = webdriver.Chrome()
        driver.get("https://www.digmi.org/huji/")
        for combination in best_comb.combinations:
            script = f'console.log(load_course({combination.course_id}, {year}, false, false));'
            driver.execute_script(script)
            for lesson in combination.lesson_tup:
                if lesson is not None:
                    value = str(lesson.id)
                    selector = f'[type="radio"][id="{combination.course_id}_{lesson.type}_{value}"]'
                    radio_button = WebDriverWait(driver, 20).until(
                        EC.presence_of_element_located((By.CSS_SELECTOR, selector)))
                    if not radio_button.is_selected():
                        radio_button.click()
        input("Press Enter to close the browser and the program...")
        driver.quit()
    except Exception as e:
        print(e)


def arguments_handling():
    """ handling the arguments from the command line
    :return: the arguments"""
    global DISTRIBUTION_FACTOR, CONFLICT_FACTOR, DAYS_FACTOR, START_AT_FACTOR, END_AT_FACTOR, TIME_GAP_FACTOR

    distribution_explain = ("the distribution factor, the higher the factor is, the more the hours are distributed in "
                            "the week")
    conflict_explain = "the conflict factor, the higher the factor is, the fewer conflicts between lesson"

    days_explain = "the days factor, the higher the factor is, the fewer days of learning"
    start_at_explain = ("the start at factor, the higher the factor is, the more the lessons don't start before the "
                        "NOT_BEFORE hour")
    end_at_explain = ("the end at factor, the higher the factor is, the more the lessons don't end after the NOT_AFTER "
                      "hour")
    time_gap_explain = "the time gap factor, the higher the factor is, the more the lessons are close to each other"
    parser = argparse.ArgumentParser(description="choose the courses, year and semester")
    parser.add_argument("-c", "--courses", help="the courses ids, separated by space", nargs="+", type=int)
    parser.add_argument("-y", "--year", help="the year of the courses", type=int)
    parser.add_argument("-s", "--semester", help="the semester of the courses 1/2", type=int)
    parser.add_argument("-df", "--distribution_factor", help=distribution_explain, type=int)
    parser.add_argument("-cf", "--conflict_factor", help=conflict_explain, type=int)
    parser.add_argument("-daf", "--days_factor", help=days_explain, type=int)
    parser.add_argument("-saf", "--start_at_factor", help=start_at_explain, type=int)
    parser.add_argument("-eaf", "--end_at_factor", help=end_at_explain, type=int)
    parser.add_argument("-tgf", "--time_gap_factor", help=time_gap_explain, type=int)
    args = parser.parse_args()
    if args.semester and args.semester not in [1, 2]:
        parser.error("the semester must be 1 or 2")
        exit()
    if args.courses:
        for course in args.courses:
            if course < 0:
                parser.error("the courses ids must be positive")
                exit()
    count_args = 0
    for arg in vars(args):
        if getattr(args, arg) is not None:
            count_args += 1
    if 0 < count_args < 3:
        parser.error("you must choose all the arguments or none of them")
        exit()
    if args.distribution_factor is not None:
        DISTRIBUTION_FACTOR = args.distribution_factor
    if args.conflict_factor is not None:
        CONFLICT_FACTOR = args.conflict_factor
    if args.days_factor is not None:
        DAYS_FACTOR = args.days_factor
    if args.start_at_factor is not None:
        START_AT_FACTOR = args.start_at_factor
    if args.end_at_factor is not None:
        END_AT_FACTOR = args.end_at_factor
    if args.time_gap_factor is not None:
        TIME_GAP_FACTOR = args.time_gap_factor
    return args


if __name__ == '__main__':
    courses = {67200,83328,67651,83326,80314, 83315}  # change this line to choose the courses
    year = 2024  # change this line to choose the year
    semester_chosen = 2  # 1 for semester a, 2 for semester b

    args = arguments_handling()
    if args.courses:
        courses = set(args.courses)
    if args.year:
        year = args.year
    if args.semester:
        semester_chosen = args.semester
    print(BANNER)
    print("pulling the courses information")
    course_list = get_courses(courses, year, semester_chosen)
    print("generating the best schedule")
    time.sleep(1.5)
    courses_combination_dict = create_combinations(course_list)
    best_comb = choose_best_schedule(courses_combination_dict)
    print(best_comb)
    print("the conflict score is: " + str(BEST_CONFLICT))
    time.sleep(3)
    print("showing the results in the Digmi website")
    time.sleep(2)
    showing_results(best_comb, year)
