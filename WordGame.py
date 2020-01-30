import string, random

class wordGame:

    def __init__(self, word):
        self.word = word.upper()

    def guess(self, letr, guesses):
        if letr in guesses: guesses = guesses.replace(letr, '')
        else: pass
        return guesses

    def check(self, letr, noOfguesses, guesses, guessed):
        if letr in self.word and len(letr) == 1: pass
        elif len(letr) != 1: pass 
        elif letr in guessed: pass
        elif letr not in string.ascii_uppercase: pass
        else: noOfguesses -= 1
        return noOfguesses

    def construct(self, guessed):
        struct = ''
        for i in self.word:
            if i in guessed: struct += i + ' '
            else: struct += '- '
        return struct
    
    def affirm(self, guessed):
        for i in self.word:
            if i not in guessed: return False
        return True

    def info(self, letr, guesses, noOfguesses):
        if letr not in string.ascii_uppercase: print('Invalid entry, enter an alphabet!')
        elif letr not in guesses: print("This letter has been guessed already, try again!")
        elif letr == '': print("You can't just enter nothing bro!")
        elif letr in self.word: print("Good guess! ")
        elif len(letr) > 1: print('Only one letter at a time bro!')
        elif noOfguesses == 0: print('You have run out of guesses, GAME OVER BRO!\nThe word was {}'.format(self.word))
        else: print("Bad guess!")
    
    def play(self):
        noOfguesses = 8
        guessed = ''
        guesses = string.ascii_uppercase
        print('A/An {}-letter word has been selected for you!'.format(len(self.word)))
        while noOfguesses > 0:
            letr = input('Enter a letter: ')
            letr = letr.upper()
            noOfguesses = self.check(letr, noOfguesses, guesses, guessed)
            if len(letr)== 1:
                guessed += letr
            print('You have {} guesses left. '.format(noOfguesses), "\n" + 'Available letters: ', ' '.join(guesses))
            print(self.construct(guessed))
            self.info(letr, guesses, noOfguesses)
            guesses = self.guess(letr, guesses)
            if self.affirm(guessed):
                print("Brava! You have guessed the word completely!")
                break

file_name = 'C:/Users/User/Desktop/coding/wordss.txt'
in_file = open(file_name,)
word_list = in_file.readline().split() 
word = random.choice(word_list)
print(word)

game = wordGame(word)
game.play()