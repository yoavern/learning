import tkinter as tk
import tkinter.font as tkFont
from ex11_utils import *
from Game_Helper import *
import tkinter.scrolledtext
import tkinter.messagebox
from start_screen import Start_screen


class GameDisplay:

    def __init__(self, game_helper) -> None:
        """
            this function creates our game display object
        """
        self.__board = game_helper.get_board()
        self.__game_helper = game_helper
        self.__score = 0
        self.__cur_word = ""
        self.__cur_path = []
        self.__valid_locs = []
        self.__used_words = []
        self.__root = tk.Tk()
        self.__bgimg = tk.PhotoImage(file='bg.png', master=self.__root)
        self.__bg_label = tk.Label(self.__root, image=self.__bgimg)
        self.__bg_label.place(x=0, y=0)
        self.__TIME = 180
        self.__curr_time = self.__TIME

        # setting title
        self.__root.title("boggle")

        # setting window size
        width = 600
        height = 500
        screenwidth = self.__root.winfo_screenwidth()
        screenheight = self.__root.winfo_screenheight()
        alignstr = '%dx%d+%d+%d' % (width, height, (screenwidth - width) / 2, (screenheight - height) / 2)
        self.__root.geometry(alignstr)
        self.__root.resizable(width=False, height=False)

        # creating the letter buttons
        self.__letters_buttons = []
        y_value = 130
        for row in range(len(self.__board)):
            new_row = []
            x_value = 190
            for col in range(len(self.__board[0])):
                # setting the button values
                letter_button = tk.Button(self.__root)
                letter_button["bg"] = "#b0cbe0"
                ft = tkFont.Font(family='Times', size=10)
                letter_button["font"] = ft
                letter_button["fg"] = "#000000"
                letter_button["bg"] = '#a664e8'
                letter_button["justify"] = "center"
                letter_button["text"] = self.__board[row][col]
                letter_button.place(x=x_value, y=y_value, width=60, height=60)
                letter_button["command"] = lambda row=row, col=col: self.button_click(row, col)

                x_value += 70
                new_row.append(letter_button)

                new_loc = row, col
                self.__valid_locs.append(new_loc)
            y_value += 70

            self.__letters_buttons.append(new_row)

            # creating the timer label
            self.__timer_label = tk.Label(self.__root)
            ft = tkFont.Font(family='Times', size=10)
            self.__timer_label["font"] = ft
            self.__timer_label["fg"] = "#FFFFFF"
            self.__timer_label["justify"] = "center"
            self.__timer_label["text"] = "time: 0"
            self.__timer_label["bg"] = "#755a8f"
            self.__timer_label["borderwidth"] = 2
            self.__timer_label["relief"] = "ridge"
            self.__timer_label.place(x=360, y=75, width=100, height=40)

            # creating the word label
            self.__word_label = tk.Label(self.__root)
            ft = tkFont.Font(family='Times', size=10)
            self.__word_label["font"] = ft
            self.__word_label["fg"] = "#FFFFFF"
            self.__word_label["justify"] = "center"
            self.__word_label["text"] = "the word that is writen will show here"
            self.__word_label["bg"] = "#755a8f"
            self.__word_label["borderwidth"] = 2
            self.__word_label["relief"] = "ridge"
            self.__word_label.place(x=220, y=420, width=215, height=30)

            # creating the submit button
            self.__submit_button = tk.Button(self.__root)
            self.__submit_button["bg"] = "#b0cbe0"
            ft = tkFont.Font(family='Times', size=10)
            self.__submit_button["font"] = ft
            self.__submit_button["fg"] = "#FFFFFF"
            self.__submit_button["bg"] = '#755a8f'
            self.__submit_button["justify"] = "center"
            self.__submit_button["text"] = "submit word"
            self.__submit_button.place(x=50, y=250, width=90, height=60)
            self.__submit_button["command"] = self.submit

            # creating the score label
            self.__score_label = tk.Label(self.__root)
            ft = tkFont.Font(family='Times', size=10)
            self.__score_label["font"] = ft
            self.__score_label["fg"] = "#FFFFFF"
            self.__score_label["justify"] = "center"
            self.__score_label["text"] = "socre: 0"
            self.__score_label["bg"] = "#755a8f"
            self.__score_label["borderwidth"] = 2
            self.__score_label["relief"] = "ridge"
            self.__score_label.place(x=50, y=150, width=90, height=60)

            # creating scroll bar
            self.__text_area = tkinter.scrolledtext.ScrolledText(self.__root)
            self.__text_area["font"] = ("Times New Roman", 8)
            self.__text_area["bg"] = "#755a8f"
            self.__text_area["fg"] = "#FFFFFF"
            self.__text_area.place(x=475, y=200, width=100, height=130)

    def check_valid_click(self, row, col):
        """
            this function checks if a cloick is valid
        """

        location = row, col

        if location in self.__valid_locs:
            self.__cur_path.append(location)
            self.__cur_word += self.__board[row][col]
            return True

        return False

    def update_valid_locations(self, row, col):
        """
            updates the valid locations for the next move
        """

        # updating the players word progress
        self.__word_label["text"] = self.__cur_word

        # getting the new valid moves
        new_valid_locs = []
        for new_row in [-1, 0, 1]:
            for new_col in [-1, 0, 1]:
                location = row + new_row, col + new_col
                if location[0] < len(self.__board) and location[0] >= 0 and location[1] < len(self.__board[0]) \
                        and location[1] >= 0 and location not in self.__cur_path:
                    new_valid_locs.append(location)
        self.__valid_locs = new_valid_locs

    def button_click(self, row, col):
        """
            handle button press
        """

        if self.check_valid_click(row, col):
            self.update_valid_locations(row, col)
            self.update_buttons()

    def submit(self):
        """
            this function handles the word the player has assembled
        """

        if self.__cur_word:

            # if the word is valid, and hasnt been used before update the relevant parameters
            if self.__cur_word not in self.__used_words and self.__cur_word in self.__game_helper.get_valid_words():
                self.__score += len(self.__cur_path) ** 2
                self.__used_words.append(self.__cur_word)
                self.__score_label["text"] = "score: " + str(self.__score)
                self.__text_area.insert(tk.INSERT, self.__cur_word + "\n")

            # reset the board
            self.__cur_path = []
            self.__cur_word = ""
            self.__word_label["text"] = self.__cur_word
            self.__valid_locs = self.__game_helper.get_all_locs()
            self.update_buttons()

    def countdown(self):
        if self.__curr_time > 0:

            if self.__curr_time == 10:  # when the game is going to finish, warning the user
                self.__timer_label['bg'] = "#800020"
            # change text in label
            self.__timer_label['text'] = self.__curr_time
            self.__curr_time -= 1
            # call countdown again after 1000ms (1s)
            self.__timer_label.after(1000, self.countdown)
        else:
            self.end_game()

    def update_buttons(self):
        """
            this function updates the button colors
        """

        # changing the button colors according to their state
        for row in range(len(self.__board)):
            for col in range(len(self.__board[0])):
                loc = row, col

                # coloring the the buttons witch are valid to press
                if loc in self.__valid_locs:
                    self.__letters_buttons[row][col]["bg"] = "#a664e8"

                # coloring the other buttons
                else:
                    self.__letters_buttons[row][col]["bg"] = '#FFFFFF'

    def end_game(self):
        """ends the game, and cheks if the user want to play again"""
        result = tk.messagebox.askquestion("Exit", "Do you want to play again?")
        if result == "yes":
            self.__root.destroy()
            start_screen = Start_screen()
            helper = start_screen.run()
            g = GameDisplay(helper)
            g.countdown()  # start timer
            g.run()

        else:
            self.__root.destroy()

    def run(self):
        """runs the game"""
        self.__root.mainloop()
