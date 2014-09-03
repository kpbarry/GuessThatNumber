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
            Console.WriteLine("Guess a number between 0 and 100!");
            int guessCount = 1;

            Random rng = new Random();

            int randomNumber = rng.Next(0,101);

            bool hasWon = false;

            while (!hasWon)
            {
                string input = Console.ReadLine();
                int guess = Convert.ToInt32(input);

                if (guess == randomNumber)
                {
                    Console.WriteLine("You guessed it in " + guessCount + " guesses.");
                    hasWon = true;

                }
                else if (guess > randomNumber)
                {
                    Console.WriteLine("Too high.");
                    guessCount++;
                }
                else
                {
                    Console.WriteLine("Too low.");
                    guessCount++;
                }
            }
        }
    }
}
