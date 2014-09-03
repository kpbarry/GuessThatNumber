using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThatNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            GuessThatNumber();
            Console.ReadKey();
        }

        static void GuessThatNumber()
        {
            Console.WriteLine("Guess a number between 0 and 100!\n If you're within +/- 10, you're getting warm. \nWithin +/- 5 and you're getting close");
            //Keep track of guesses
            int guessCount = 0;

            //Generate random number between 0 and 100 to guess
            Random rng = new Random();
            int randomNumber = rng.Next(0,101);

            //Stop loop when user has guessed number
            bool hasWon = false;

            //While number is not guessed
            while (!hasWon)
            {
                //Get input and convert to integer for comparison
                string input = Console.ReadLine();
                int guess = Convert.ToInt32(input);

                //Increase guessCount when guessing, print out # of guesses, stop loop
                if (guess == randomNumber)
                {
                    guessCount++;
                    Console.WriteLine("You guessed it in " + guessCount + " guesses.");
                    hasWon = true;
                }
                //If guess is higher than randomNumber, print "Too high"
                else if (guess > randomNumber)
                {
                    Console.WriteLine("Too high.");
                    if (guess - randomNumber < 5)
                    {
                        Console.WriteLine("Getting close.");
                    }
                    else if (guess - randomNumber < 10)
                    {
                        Console.WriteLine("Getting warm.");
                    }
                    guessCount++;
                }
                //If lower, print "Too low", check if they're getting close, increase guess count
                else
                {
                    Console.WriteLine("Too low.");
                    if (randomNumber - guess < 5)
                    {
                        Console.WriteLine("Getting close.");

                    }
                    else if (randomNumber - guess < 10)
                    {
                        Console.WriteLine("Getting warm.");
                    }
                    guessCount++;
                }
            }
            //Ask if they want to play again
            Console.WriteLine("Would you like to play again?");
            string playAgain = Console.ReadLine();
            //If y, Y, yes or Yes, play again, otherwise quit
            if (playAgain == "y" || playAgain == "yes")
            {
                GuessThatNumber();
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
