﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fussballmannschaft
{
    public class Feldspieler
    {
        public bool SchiesseTor()
        {
            Random random = new Random();
            return random.Next(100) < 50; //50% chances
        }
    }
}
