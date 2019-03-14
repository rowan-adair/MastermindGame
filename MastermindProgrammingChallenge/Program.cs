using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MastermindProgrammingChallenge
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[]args)
        {
            RunConsole();
        }

        static void RunApp()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartMastermind());
        }

        static void RunConsole()
        {
            Console.WriteLine("************** Let's play Master-Mind **************\n");
            string name = Mastermind.GetPlayerName();
            do
            {
                Mastermind.PlayInConsole(name);
                Console.Write("\nWould you like to play again (Y/N)? ");
            }
            while (Console.ReadLine().ToUpper() == "Y");
        }


    }
}
