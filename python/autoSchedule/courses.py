import datetime
import typing

p = "   "


class Curriculum:
    """Curriculum class represents an optional system and it's score."""

    def __init__(self, combinations: typing.Tuple['Combination'], score: float):
        self.combinations = combinations
        self.score = score

    def __str__(self):
        return f"Curriculum:\n{p}{', '.join(str(comb) for comb in self.combinations)}\nScore: {self.score}"


class Combination:
    """Combination class represents a combination of lessons of a course.
    for example - lesson_tup = (lecture, practice, lab)."""

    def __init__(self, course_id: int, lesson_tup: typing.List['Lesson']):
        self.course_id = course_id
        self.lesson_tup = lesson_tup

    def __str__(self):
        lessons_str = "\n".join(str(lesson) for lesson in self.lesson_tup if lesson is not None)
        return f"Combination - Course ID: {self.course_id}\nLessons:\n{lessons_str}"


class Course:
    """Course class represents a course in the curriculum."""

    def __init__(self, id: int, name: str, lessons: typing.List['Lesson']):
        self.id = id
        self.name = name
        self.lessons = lessons

    def __str__(self):
        lessons_str = "\n".join(str(lesson) for lesson in self.lessons)
        return f"Course ID: {self.id}\nCourse Name: {self.name}\nLessons:\n{lessons_str}"


class Lesson:
    """Lesson class represents a lesson of a course."""

    def __init__(self, id: int, teacher: str, type: str, hours: typing.List['Hour']):
        self.id = id
        self.teacher = teacher
        self.type = type
        self.hours = hours

    def __str__(self):
        hours_str = "\n".join(str(hour) for hour in self.hours)
        return f"{p}Lesson ID: {self.id}\n{p}Teacher: {self.teacher}\n{p}Type: {self.type}\n{p}Hours:\n{hours_str}"


class Hour:
    """Hour class represents the time of one lesson."""

    def __init__(self, id: int, semester: int, day: int, start: datetime.datetime, end: datetime.datetime):
        self.id = id
        self.semester = semester
        self.day = day
        self.start = start
        self.end = end

    def __str__(self):
        return f"{p * 2}Hour ID: {self.id}\n{p * 2}Semester: {self.semester}\n{p * 2}Day: {self.day}\n{p * 2}Start: {self.start}\n{p * 2}End: {self.end}"
