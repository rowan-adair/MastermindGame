using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MastermindProgrammingChallenge
{

    

    class Mastermind
    {
        // Colour Enumerration
        private enum Colour {red,green,blue,yellow};

        // For console interaction and testing.
        public static string GetPlayerName()
        {
            Console.Write("Please enter your name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome {0}, have fun", name);
            return name;
        }
        
        public static void PlayInConsole(string name)
        {
            int difficulty = GetDifficulty();
            int numberCount = GetRandomNumber();
            bool won = false;
            Console.Write(numberCount + " it is. Let's play.\n");   
            int[] PCArray = RandomNumberArrayGeneration(numberCount);
            Console.WriteLine("A {0}-digit number has been chosen. Each possible digit may be the number 1 to 4.\n", numberCount);
            for (int allowedAttempts = difficulty * numberCount; allowedAttempts > 0 && !won; allowedAttempts--)
            {
                Console.WriteLine("\nEnter your guess ({0} guesses remaining)", allowedAttempts);

                int[] userArray = UserGuess(numberCount);

                if(CountHits(PCArray,userArray) == numberCount)
                {
                    won = true;
                }
            }

            if (won)
                Console.WriteLine("You win, {0}!", name);
            else
                Console.WriteLine("Oh no, {0}! You couldn't guess the right number.", name);

            Console.Write("The correct number is: ");
            for (int j = 0; j < numberCount; j++)
                Console.Write(PCArray[j] + " ");
        }

        
        // Still relies on console interaction, will build for user form.
        public static int GetRandomNumber()
        {
            int number = 0;
            do
            {
                try
                {
                    number = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("You must pick a number between 1 and 4, otherwise your choice is invalid.");
                }
            } while (number > 4 || number < 1);
            return number;
        }

        public static int[] RandomNumberArrayGeneration(int Size)
        {
            int eachNumber;
            int[] randomNum = new int[Size];
            Random rnd = new Random();

            // For Testing
            // Console.WriteLine("PC Number : ");
            for (int i = 0; i < randomNum.Length; i++)
            {
                eachNumber = rnd.Next(1, 5);
                randomNum[i] = eachNumber;
                Console.Write(eachNumber);
            }
            Console.WriteLine();
            return randomNum;
        }


        // Returns user guess.
        public static int[] UserGuess(int uSize)
        {
            int n = 0;
            int[] guess = new int[uSize];
            for (int i = 0; i < uSize; i++)
            {
                Console.WriteLine("Digit {0}: ", i+1);
                while (!int.TryParse(Console.ReadLine(), out n) || n < 1 || n > 4)
                {
                    Console.WriteLine("Invalid Number!");
                }
                guess[i] = n;
            }
            Console.WriteLine();
            Console.WriteLine("Your guess: ");
            for (int i = 0; i < uSize; i++)
            {
                Console.WriteLine("{0} ", guess[i]);
            }
            return guess;
        }

        // Gets chosen difficulty
        public static int GetDifficulty()
        {
            int diffLevel = 0;
            while (diffLevel < 1 || diffLevel > 3)
            {
                try
                {
                    Console.WriteLine("Choose a difficulty level (1 = easy, 2 = medium, 3 = hard)");
                    diffLevel = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Try again");
                }
            }
            return diffLevel;
        }

        public static int CountHits(int[] PCArray, int[] userArray)
        {
            int hits = 0;
            for (int i = 0; i < PCArray.Length; i++) if(PCArray[i] == userArray[i]) hits++;
            return hits;
        }
        
    }
}
