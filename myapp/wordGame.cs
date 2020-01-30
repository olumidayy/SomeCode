using System;
using System.IO;

namespace myapp
{
    class WordGame{
        public string word {get; set;}
        public string guessed {set; get;}
        public int noofGuesses {get; set;}
        

        public WordGame(string Word = "", int NoofGuesses = 8, string Guessed = ""){
            word = Word;
            noofGuesses = NoofGuesses;
            guessed = Guessed;
        }

        public string adder(string i){
            if (!word.Contains(i) && !guessed.Contains(i)) noofGuesses--;
            else {}
            guessed += i;
            return guessed;
        }

        bool confirm(){
            foreach(char i in word){
                if(!guessed.Contains(i)) return false;                
            }return true;
        }

        public string crossCheck(){
            string display = "";
            foreach(char i in word){
                if(guessed.Contains(i)){
                    display += String.Format("{0} ", i);
                }else display += "_ ";
            }return display;
        }

        public void showMessages(string i){
            string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if(i =="")
                System.Console.WriteLine("You must enter at least one letter!!");
            else if(isAlreadyGuessed(i)){
                System.Console.WriteLine("This letter has been guessed already");
            }else if(!isValidEntry(i)){
                System.Console.WriteLine("You may enter only one character at a time.");
            }else if(!alpha.Contains(i))
                System.Console.WriteLine("Invalid entry!!");
            else if(word.Contains(i)){
                System.Console.WriteLine("Good guess!");
                adder(i);
            }else{ 
                System.Console.WriteLine("Oops, that letter isn't in my word!");
                adder(i);
            }
        }

        void available(){
            string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ", newAlpha = "";
            foreach(char i in alpha){
                if(guessed.Contains(i)){}
                else newAlpha += String.Format("{0} ", i);
            }System.Console.WriteLine($"Available letters: {newAlpha}");
            System.Console.WriteLine($"You have {noofGuesses} guess(es) left.");
        }

        bool isAlreadyGuessed(string i){
            if(guessed.Contains(i)){
                return true;
            }return false;
        }

        bool isValidEntry(string i){
            if(i.Length != 1){
                return false;
            }return true;
        }
        public void startGame(){
            System.Console.WriteLine($"A/An {word.Length}-letter word has been picked for you!");
            while (noofGuesses > 0){
                System.Console.WriteLine(crossCheck());
                available();
                System.Console.Write("Enter a letter: ");
                string i = Console.ReadLine().ToUpper();
                showMessages(i);               
                if(confirm()){
                    System.Console.WriteLine("Congrats! You've completed the word!\nEnter account number to cash out!");
                    break;
                }

            }if(noofGuesses==0){
                System.Console.WriteLine("Game Over!!!");
                System.Console.WriteLine($"The word was {word}.");
            }
        }

    }
}