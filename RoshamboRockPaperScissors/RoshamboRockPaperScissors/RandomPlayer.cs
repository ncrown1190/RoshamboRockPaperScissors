using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshamboRockPaperScissors
{
    internal class RandomPlayer : Player
    {
        public RandomPlayer(string name)
        {
            Name = name;
        }
        public override Roshambo GenerateRoshambo()
        {
            Random random = new Random();
            return (Roshambo)random.Next(0, 3);
        }
    }
}
