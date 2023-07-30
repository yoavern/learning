from ex11_utils import *
from boggle_board_randomizer import *



class Game_Helper:

    def __init__(self) -> None:
        self.__board = randomize_board()
        self.__all_locs = [(row, col) for col in range(len(self.__board)) for row in range(len(self.__board))]
        words = set()
        with open('boggle_dict.txt', 'r') as f:
            for line in f:
                words.add(line.strip())

        self.__valid_words = set(map(lambda x: x[0], gen_all(self.__board, words)))

    def get_all_locs(self):
        return self.__all_locs

    def get_valid_words(self):
        return self.__valid_words

    def get_board(self):
        return self.__board
