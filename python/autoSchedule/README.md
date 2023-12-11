# Auto Schedule Readme

## Introduction

Welcome to the Auto Schedule project! This tool is designed to help students efficiently plan their course schedules based on various factors such as distribution of hours, lesson conflicts, distance between classes etc.

## Getting Started
### Prerequisites
-Python 3.x

-Selenium

-Chrome WebDriver - make sure it's compatible with the chrome version you have.

# Installation
1. Clone the repository to your local machine.
2. Navigate to the project directory.
3. Install the required dependencies, make sure the webdriver is in the project directory.

## Usage
1. Open the terminal.
2. Navigate to the project directory.
3. Run the script with the desired arguments, for example:

   ```bash
   python courses_scheduler.py -c 67200 83328 67651 83326 80314 83315 -y 2024 -s 2 -df 4 -cf 50 -daf 7 -saf 1 -eaf 1 -tgf 2
   ```

   - `-c` or `--courses`: Specify the courses by providing their IDs.
   - `-y` or `--year`: Set the academic year.
   - `-s` or `--semester`: Choose the semester (1 for semester A, 2 for semester B).
   - Additional optional arguments to customize the schedule optimization factors:
     - `-df` or `--distribution_factor`: Distribution factor (default is 4).
     - `-cf` or `--conflict_factor`: Conflict factor (default is 50).
     - `-daf` or `--days_factor`: Days factor (default is 7).
     - `-saf` or `--start_at_factor`: Start at factor (default is 1).
     - `-eaf` or `--end_at_factor`: End at factor (default is 1).
     - `-tgf` or `--time_gap_factor`: Time gap factor (default is 2).
   
	for more informaiton check auto_curriculum.py -h.


## Usage - another option

1. Open the courses_scheduler.py file in a text editor.
2. Customize the course selection, year, and semester according to your preferences:

```python
courses = {67200, 83328, 67651, 83326, 80314, 83315}  # Add or modify course IDs
year = 2024  # Set the desired academic year
semester_chosen = 2  # 1 for semester A, 2 for semester B
```
3.optionally, you can adjust additional parameters such as distribution factor, conflict factor, days factor, start and end time factors, and time gap factor based on your preferences. These factors influence the optimization criteria for generating the best schedule.

```python
DISTRIBUTION_FACTOR = 4
CONFLICT_FACTOR = 50
DAYS_FACTOR = 7
START_AT_FACTOR = 1
END_AT_FACTOR = 1
TIME_GAP_FACTOR = 2
```
4. Run the script:
```bash
python courses_scheduler.py
```
5. Follow the prompts to view the generated schedule and interact with the Digmi website to visualize the results.

## Video Demonstrating

https://github.com/yoavern/learning/assets/133568608/4ea82cbd-1442-434c-afff-216f36a3e6e9




