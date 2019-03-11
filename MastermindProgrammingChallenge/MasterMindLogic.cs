using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MastermindProgrammingChallenge
{
    class MasterMindLogic
    {
       static void Main(String[] args)
        {
            string name;
            Console.WriteLine();
            Console.WriteLine("Please enter your name : ");
            name = Console.ReadLine();
            Console.WriteLine("Welcome {0}, have fun!", name);

            int numCount = 0;
            int diffLevel = 0;

            int randomNumber = getRandomNumber(numCount);

            Console.WriteLine("{0} it is, let's play.",randomNumber);
            Console.WriteLine();

            int[] PCArray = generateRandomNumbers(randomNumber);

            Console.WriteLine();

        }

        private static int[] generateRandomNumbers(int randomNumber)
        {
            throw new NotImplementedException();
        }

        private static int getRandomNumber(int numCount)
        {
            int number = 0;

            do
            {
                try
                {
                    Console.WriteLine("How many numbers would you like to use in playing the game (4-10)? ");
                    number = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("You must pick a number between 1 and 4, otherwise your choice is invalid.");
                    Console.WriteLine();
                }
            } while (number < 4 || number > 10);
            return number;
        }
    }
}
