using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshamboRockPaperScissors
{
    internal class RockPlayer : Player
    {
        public RockPlayer(string name)
        {
            Name = name;
        }
        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.rock;
        }
    }
}
