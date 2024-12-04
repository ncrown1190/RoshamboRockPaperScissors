using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshamboRockPaperScissors
{
    internal class HumanPlayer : Player
    {
        public HumanPlayer(string name)
        {
            Name = name;
        }
        public override Roshambo GenerateRoshambo()
        {
            Console.Write("Do you want Rock, Paper, Scissors:  ");
            string input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "rock":
                    return Roshambo.rock;
                case "paper":
                    return Roshambo.paper;
                default:
                    return Roshambo.scissors;
            }


        }
    }
}
