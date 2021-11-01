using System;
using System.Collections.Generic;
using System.Text;

namespace sem2_6
{
    class Prostokat
    {
        public double x, y;
        public Prostokat(double w1, double w2)
        {
            x = w1;
            y = w2;
        }
        public  double Pole()
        {
            return (x * y);
        }
        public override string ToString()
        {
            return $"Wymiar x: {x} | Wymiar y: {y} | Pole: {Pole()}";
        }
    }
}
