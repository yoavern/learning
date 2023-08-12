from selenium import webdriver
from selenium.webdriver.chrome.service import Service
from selenium.webdriver.common.by import By
from webdriver_manager.chrome import ChromeDriverManager


def loggingCourse(idCourse, idTargil):
    # loging to the course
    looging = driver.find_element(by=By.ID, value=idCourse)
    looging.click()
    # handling alert
    driver.switch_to.alert.accept()
    # loging to the targil
    targil = driver.find_element(by=By.XPATH, value="//input[@value=" + str(idTargil) + "]")
    targil.click()
    # enter the choices to the system
    enter = driver.find_element(by=By.ID, value="ContentPlaceHolder1_ucMandatoryAdditionalLessonsSelection_btnAssign")
    enter.click()


# the function loging to the site by name and password
def logging_site(name, password):
    nameTextBxx = driver.find_element(by=By.ID, value="edtUsername")
    passowrdTextBox = driver.find_element(by=By.ID, value="edtPassword")
    btnLogin = driver.find_element(by=By.ID, value="btnLogin")

    nameTextBxx.send_keys(name)
    passowrdTextBox.send_keys(password)
    btnLogin.click()


# the function closing a pop-up window
def close_pop_window():
    closePopUpWindow = driver.find_element(by=By.ID, value="ContentPlaceHolder1_btnCloseThresholdRemark")
    closePopUpWindow.click()


# main function
if __name__ == '__main__':
    driver = webdriver.Chrome(service=Service(ChromeDriverManager().install()))
    driver.get("https://inbar.biu.ac.il/tirgul2/Login.aspx")
    name = "enter your ID"  # id
    password = "enter your PASSWORD"  # password

    logging_site(name, password)  # loging in to the site

    # entering to the enrollment
    rishumBtn = driver.find_element(by=By.ID, value="tvMainn11")
    rishumBtn.click()

    close_pop_window()  # closing pop up window

    # starting to enroll:

    # choosing the tab
    tabChoser = driver.find_element(by=By.ID, value="ContentPlaceHolder1_gvBalanceMatrix_lblBalanceNameMatrix_6")
    tabChoser.click()

    # open the option to choose a course
    shibuzFromList = driver.find_element(by=By.ID, value="tbActions_ctl04_btnAddLessons")
    shibuzFromList.click()

    # loging to the course
    logCourse = driver.find_element(by=By.ID, value="ContentPlaceHolder1_gvLinkToLessons_btnLinkStudentToLesson_0")
    logCourse.click()
    # handling alert
    driver.switch_to.alert.accept()

    # open the option to choose a course- the main courses
    shibuzFromList = driver.find_element(by=By.ID, value="ContentPlaceHolder1_gvBalance_lblBalanceName_8")
    shibuzFromList.click()

    # loging to courses:
    # example of courses:

    computerScienceCourse = "ContentPlaceHolder1_gvLinkToLessons_btnLinkStudentToLesson_0"
    computerScienceTargil = '748355'
    loggingCourse(computerScienceCourse, computerScienceTargil)

    bdidaCourse = "ContentPlaceHolder1_gvLinkToLessons_btnLinkStudentToLesson_33"
    bdidaTargil = '756992'
    loggingCourse(bdidaCourse, bdidaTargil)

    linnAlgebraCourse = "ContentPlaceHolder1_gvLinkToLessons_btnLinkStudentToLesson_11"
    linnAlgebraTargil = '754097'
    loggingCourse(linnAlgebraCourse, linnAlgebraTargil)

    infiniteMathCourse = "ContentPlaceHolder1_gvLinkToLessons_btnLinkStudentToLesson_44"
    infiniteMathTargil = '748307'
    loggingCourse(infiniteMathCourse, infiniteMathTargil)

    # won't close
    value = input("Please enter a string:\n")
    print(f'You entered {value}')
