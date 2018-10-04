using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class ComputerChoice
    {
        public static int CompChoice()
        {
            int toReturn;
            Random rnd = new Random();
            decimal rough = rnd.Next(1, 4);
            toReturn = Convert.ToInt32(Math.Floor(rough));
            return toReturn;
        }
    }
}
