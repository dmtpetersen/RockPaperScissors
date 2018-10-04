using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameOver = false;
            while (!gameOver)
            {
                Console.Clear();
                UI.Breaker();
                UI.Welcome();
                DetermineWinner.Determine(UI.PlayerChoice(), ComputerChoice.CompChoice());
                UI.Breaker();
                gameOver = UI.KeepPlaying();
            }
        }
    }
}
