from typing import List, Tuple, Iterable, Optional
import functools

Board = List[List[str]]
Path = List[Tuple[int, int]]

def check_valid_location(location: tuple[int, int], last_location: tuple[int, int], board: Board) -> bool:
    """
        this function checks if a given step is valid for our board
    """
    # checking if the new location is in our board
    if location[0] < len(board) and location[0] >= 0 and location[1] < len(board[0])\
        and location[1] >= 0:

        # if it is check is it's a valid move from our previus location, by making sur the distance between the cubes
        # is less than 2
        vertical_distance: int = location[0] - last_location[0]
        horizontal_distance: int = location[1] - last_location[1]
        if ((vertical_distance **2) + (horizontal_distance **2)) **0.5 < 2:
            return True
    
    return False

def is_valid_path(board: Board, path: Path, words: Iterable[str]) -> Optional[str]:
    """
        this function checks if a given path is valid
        is in ok to use?
        check format 
    """
    

    word: str = ""

    if path:
        last_cube: tuple[int, int] = path[0]

    # creating a word from our path, if one of the locations is invalid return None
    for cube in range(len(path)):
        if path[cube] in path[:cube] + path[cube+1:]:
            return None
        elif check_valid_location(path[cube], last_cube, board):
            word += board[path[cube][0]][path[cube][1]]
            last_cube = path[cube]
        else:
            return None

    return word if word in words else None

    
def find_length_n_paths_helper(word: str, path: list[tuple[int, int]],\
      n: int, board: Board, words: Iterable[str], output_list: list[list[tuple[int, int]]]) -> None:
    """
        this is a helper function four our length n path function
    """

    # if the legth of the path is n and the word is valid add the path to our output list
    if len(path) >= n:
        if word in words:
            output_list.append(path)
        return

    new_words: set[str] = set()

    for value in words:
        if word == value[:len(word)]:
            new_words.add(value)

    # if a move is valid check a path with this move
    if new_words:
        for row in [-1, 0, 1]:
                for col in [-1, 0, 1]:
                    new_row: int = path[-1][0] + row
                    new_col: int = path[-1][1] + col
                    new_loc: tuple[int, int] = new_row, new_col
                    if new_row < len(board) and new_row >= 0 and new_col < len(board[0]) and new_col >= 0 and new_loc not in path:
                        find_length_n_paths_helper(word + board[new_row][new_col], path + [new_loc], n, board, new_words, output_list)


def find_length_n_words_helper(word: str, path: list[tuple[int, int]],\
      n: int, board: Board, words: Iterable[str], output_list: list[list[tuple[int, int]]]) -> None:
    """
        this is a helper function four our length n words function
    """

    # if the legth of the word is n and the word is valid add the path to our output list
    if len(word) >= n:
        if len(word) == n and word in words:
            output_list.append(path)
        return

    new_words: set[str] = set()

    for value in words:
        if word == value[:len(word)]:
            new_words.add(value)

    # if a move is valid check a path with this move
    if new_words:
        for row in [-1, 0, 1]:
                for col in [-1, 0, 1]:
                    new_row: int = path[-1][0] + row
                    new_col: int = path[-1][1] + col
                    new_loc: tuple[int, int] = new_row, new_col
                    if new_row < len(board) and new_row >= 0 and new_col < len(board[0]) and new_col >= 0 and new_loc not in path:
                        find_length_n_words_helper(word + board[new_row][new_col], path + [new_loc], n, board, new_words, output_list)


def find_length_n_paths(n: int, board: Board, words: Iterable[str]) -> List[Path]:
    """
        this is our path legth function
    """

    valid_paths: list[list[tuple[int, int]]] = []

    if n == 0:
        return []

    # checking all the cubes
    for row in range(len(board)):
        for col in range(len(board[0])):
            starting_location: tuple[int, int] = row, col
            find_length_n_paths_helper(board[row][col], [starting_location], n, board, words, valid_paths)
    
    return valid_paths


def find_length_n_words(n: int, board: Board, words: Iterable[str]) -> List[Path]:
    """
        this is our n words function
    """

    valid_paths: list[list[tuple[int, int]]] = []

    if n == 0:
        return []

    # checking all the cubes
    for row in range(len(board)):
        for col in range(len(board[0])):
            starting_location: tuple[int, int] = row, col
            find_length_n_words_helper(board[row][col], [starting_location], n, board, words, valid_paths)
    
    return valid_paths


def gen_all_helper(word: str, path: list[tuple[int, int]], board: Board, words: Iterable[str],\
     output_list: list[tuple[str, list[tuple[int, int]]]]) -> None:

    new_words: set[str] = set()

    for value in words:
        if word == value:
            value_to_add: tuple[str, list[tuple[int, int]]] = word, path
            output_list.append(value_to_add)
        elif word == value[:len(word)]:
            new_words.add(value)

    # if a move is valid check a path with this move
    if new_words:
        for row in [-1, 0, 1]:
            for col in [-1, 0, 1]:
                new_row: int = path[-1][0] + row
                new_col: int = path[-1][1] + col
                new_loc: tuple[int, int] = new_row, new_col
                if new_row < len(board) and new_row >= 0 and new_col < len(board[0]) and new_col >= 0 and new_loc not in path:
                    gen_all_helper(word + board[new_row][new_col], path + [new_loc], board, new_words, output_list)


def gen_all(board: Board, words):
    """
        this function return all the valid words and paths on the board
    """
    
    all: list[list[tuple[str, list[tuple[int, int]]]]] = []

    # checking all the cubes
    for row in range(len(board)):
        for col in range(len(board[0])):
            starting_location: tuple[int, int] = row, col
            gen_all_helper(board[row][col], [starting_location], board, words, all)

    return all



def max_score_paths(board: Board, words: Iterable[str]) -> List[Path]:
    """
        this function returns the paths that will give the player the max score
    """

    # generating all the valid paths and words using our efficent algorithem
    all = sorted(gen_all(board, words))
    paths: list[list[tuple[int, int]]] = []
    
    # returning the longest path for each word
    if all:
        cur_word: str = all[0][0]
        path_to_add: list[tuple[int, int]] = all[0][1]

    ind: int = 0
    while ind < len(all):
        while ind < len(all) and all[ind][0] == cur_word :
            if len(all[ind][1]) > len(path_to_add):
                path_to_add = all[ind][1]
            ind += 1

        paths.append(path_to_add)
        if ind < len(all):
            cur_word = all[ind][0]
            path_to_add = all[ind][1]

    return paths


