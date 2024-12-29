import random

class Tree:
    def __init__(self, word):
        self.word = word
        self.guessed_letters = set()
        self.incorrect_guesses = 0
        self.max_attempts = 10

    def add_guess(self, guess):
        self.guessed_letters.add(guess)

    def is_correct(self, guess):
        return guess in self.word

    def current_state(self):
        state = ""

        for letter in self.word:
            if letter in self.guessed_letters:
                state += letter
         
            else:
                state += "_"
        return state

    def is_game_won(self):
        for letter in self.word:
            if letter not in self.guessed_letters:
                return False
            
        return True

    def is_lost(self):
        return self.incorrect_guesses >= self.max_attempts

    def incorrect_guesses_count(self):
        return self.incorrect_guesses

    def add_incorrect_guesses(self):
        self.incorrect_guesses += 1

    def remaining_attempts(self):
        return self.max_attempts - self.incorrect_guesses


class Game:
    def __init__(self):
        self.word_list = ["python", "hangman", "data", "project", "computer", "programming", "algorithms", "structures"]
        self.tree = None

    def choose_random_word(self):
        return random.choice(self.word_list)

    def start_game(self):
        word = self.choose_random_word()
        self.tree = Tree(word)

        print("Welcome to Hangman!")
      
        print("Try to guess the word!")
        
        while not self.tree.is_game_won() and not self.tree.is_lost():
            self.play_round()

        if self.tree.is_game_won():
            print(f"Congratulations! You guessed the word: {self.tree.word}")
        
        else:
            print(f"You lost! The word was: {self.tree.word}")

    def play_round(self):

        print(f"Word: {self.tree.current_state()}")

        print(f"Remaining Attempts: {self.tree.remaining_attempts()}")
        
        guess = input("Guess a letter: ").lower()

        if len(guess) != 1 or not guess.isalpha():
            print("Please enter a valid letter.")
            return

        if guess in self.tree.guessed_letters:
            print("You already guessed that letter!")
            return

        self.tree.add_guess(guess)

        if self.tree.is_correct(guess):
            print(f"Good guess! '{guess}' is in the word.")
        else:
            self.tree.add_incorrect_guesses()
            print(f"Incorrect guess. '{guess}' is not in the word.")


if __name__ == "__main__":
    game = Game()
    game.start_game()
