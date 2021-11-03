using System;
using System.Collections.Generic;
using System.Text;

namespace sem2_6_z2
{
    public abstract class Figura
    {
        public string kolor { get; set; }
        public ConsoleColor color { get; set; }

        public abstract double Pole();
        public override string ToString()
        {
            return $"Kolor: {color} ";
        }
    }
    

   
}
