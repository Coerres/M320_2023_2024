﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fussballmannschaft
{
    public class Torwart
    {
        public bool HalteTor()
        {
            Random random = new Random();
            return random.Next(100) < 70; //70% chances that he catches the ball
        }
    }
}
