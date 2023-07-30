from start_screen import Start_screen
from GameDisplay import GameDisplay
from Game_Helper import *


if __name__ == '__main__':
    start_screen = Start_screen()
    helper = start_screen.run()
    g = GameDisplay(helper)
    g.countdown()  # start timer
    g.run()