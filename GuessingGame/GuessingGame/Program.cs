using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "giraffe"; //the secret word
            string guess = ""; //user input var
            int guessCount = 0; //how many times the user tried to guess
            int guessLimit = 3; //how many times the user can guess
            bool outOfGuesses = false; //tells us whether or not user is out of guesses

            while (guess != secretWord && !outOfGuesses) // if guess is not correct
           //AND they're NOT out of guesses

            {
                if (guessCount<guessLimit) //while the user still has tries, he can gues:
                {
                    Console.WriteLine("Enter guess :");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else //but if they run out of guesses, its over. the boolean is true
                {
                    outOfGuesses = true;
                }
                
            }
            if (outOfGuesses == true) //if they're out of guesses
            {
                Console.WriteLine("You lose! ");
            }
            else //if they guess correctly
            {
                Console.WriteLine("You win! ");
            }
        }
    }
}
