using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MastermindProgrammingChallenge
{
    class Mastermind
    {
        // For console interaction and testing.
        public static string GetPlayerName()
        {
            Console.Write("Please enter your name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome {0}, have fun", name);
            return name;
        }


        // Still relies on console interaction, will build for user form.
        public static int GetRandomNumber(int numCount)
        {
            int number = 0;
            do
            {
                try
                {
                    number = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("You must pick a number between 1 and 4, otherwise your choice is invalid.");
                }
            } while (number < 4 || number > 10);
            return number;
        }

        public static int[] RandomNumberArrayGeneration(int Size)
        {
            int eachNumber;
            int[] randomNum = new int[Size];
            Random rnd = new Random();

            Console.WriteLine("PC Number : ");
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
                    Console.WriteLine("Inalid Number!");
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
        public static int GetDifficulty(int difficulty)
        {
            int diffLevel = 0;
            while (difficulty < 1 || difficulty > 3)
            {
                try
                {
                    Console.WriteLine("Choose a difficulty level (1 = hard, 2 = medium, 3 = hard)");
                    diffLevel = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Try again");
                }
            }
            return diffLevel;
        }

        public int CountHits(int[] PCArray, int[] userArray)
        {
            int hits = 0;

            for (int i = 0; i < PCArray.Length; i++)
            {
                if(PCArray[i] == userArray[i])
                {
                    hits++;
                }
            }
            return hits;
        }
        
    }
}
