using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public static class UI
    {
        public static void Breaker()
        {
            Console.WriteLine("====================================================================================================\n");
        }

        public static void Welcome()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors. Please select your move by writing the corresponding digit.\n1.Rock\n2.Paper\n3.Scissors\n");
        }

        public static int PlayerChoice()
        {
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
            {
                Console.WriteLine("Invalid input, try again.\n");
            }
            return choice;
        }
        public static bool KeepPlaying()
        {
            Console.WriteLine("Play again? Press 'y' to continue, or press any key to exit.");
            if (Console.ReadLine() != "y")
            {
                return true;
            }
            return false;
        }
    }
}
