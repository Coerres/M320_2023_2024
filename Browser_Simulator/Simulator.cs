﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Browser_Simulator
{
    public class Simulator
    {
        private StringStack stack = new StringStack();
        public void Run()
        {
            while(true)
            { 
                Console.Write("Geben Sie eine URL ein:");
                string url = Console.ReadLine();
                switch(url)
                {
                    case "e":
                        break;
                    case "p":
                        Undo();
                        break;

                    default:
                    BrowseURLhere(url);
                        break;

                }
                
                
                if (url  == "e")
                {
                    break;
                }
                
            }
        }

        private void BrowseURLhere(string url)
        {
            Console.WriteLine($"Lade {url}");
            stack.Push(url);
        }

        private void Undo()
        {
            stack.Pop();
        }

    }
}
