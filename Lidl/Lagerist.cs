﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lidl
{
    public class Lagerist : Person
    {
        public int Groesse { get; set; }

        public void LagereEin()
        {
            Console.WriteLine($"Lagerist {Vorname} {Name} lagert ein.");
        }

        public override void Trage()
        {
            Console.WriteLine($"Person {Vorname} {Name} trägt mit Stapler.");
        }
    }
}
