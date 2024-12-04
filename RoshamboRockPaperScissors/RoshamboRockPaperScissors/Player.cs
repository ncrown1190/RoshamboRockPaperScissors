﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshamboRockPaperScissors
{
    internal abstract class Player
    {
        public string Name { get; set; }

        public abstract Roshambo GenerateRoshambo();
    }
}
