using System;


namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Guessing game 1.0 developed by Rally");
            Console.ResetColor();
            string secretWord = "giraffe"; //the secret word
            string guess = ""; //user input var
            int guessCount = 0; //how many times the user tried to guess
            int guessLimit = 3; //how many times the user can guess
            bool outOfGuesses = false; //tells us whether or not user is out of guesses
            
            do //while he can still guess, the program will run
            {
                Console.WriteLine("enter guess! you only have 3 tries though! ");
                guess = Console.ReadLine();

                if (guess != secretWord) //if guess is not correct
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("incorrect! ");
                    guessCount++;
                    Console.ResetColor();
                }

                if (guessCount == guessLimit) //if user attempted 3 times incorrectly
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("attempts exhausted! ");
                    outOfGuesses = true;
                    Console.ResetColor();
                }
                if (guess == secretWord) //if he guessed correctly
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("correct! ");
                    Console.ResetColor();
                }
            }
            while (!outOfGuesses && guessCount < guessLimit && guess!=secretWord);

            if (outOfGuesses ==true | guess==secretWord ) //if program is terminated
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("program terminated! ");
                Console.ResetColor();
            }

            Console.ReadLine();
        }
    }
}
        
    

