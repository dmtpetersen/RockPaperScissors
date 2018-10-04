using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class DetermineWinner
    {
        public static void Determine(int playerChoice, int computerChoice)
        {
            switch (playerChoice)
            {
                case 1:
                    switch (computerChoice)
                    {
                        case 1:
                            Console.WriteLine("Computer chose Rock. Draw");
                            break;
                        case 2:
                            Console.WriteLine("Computer chose Paper. Computer win");
                            break;
                        case 3:
                            Console.WriteLine("Computer chose Scissors. Player win");
                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    switch (computerChoice)
                    {
                        case 1:
                            Console.WriteLine("Computer chose Rock. Player win");
                            break;
                        case 2:
                            Console.WriteLine("Computer chose Paper. Draw");
                            break;
                        case 3:
                            Console.WriteLine("Computer chose Scissors. Computer win");
                            break;
                        default:
                            break;
                    }
                    break;
                case 3:
                    switch (computerChoice)
                    {
                        case 1:
                            Console.WriteLine("Computer chose Rock. Computer Win");
                            break;
                        case 2:
                            Console.WriteLine("Computer chose Paper. Player win");
                            break;
                        case 3:
                            Console.WriteLine("Computer chose Scissors. Draw");
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
