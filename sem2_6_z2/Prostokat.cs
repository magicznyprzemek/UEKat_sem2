using System;
using System.Collections.Generic;
using System.Text;

namespace sem2_6_z2
{
    class Prostokat : Figura
    {
        
        public double x, y;
        public Prostokat(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public override double Pole()
        {
            return x * y;
        }
        public override string ToString()
        {
            return base.ToString()+$"| Wymiary: {x}x{y} | Pole prostokąta: {Pole()}";
        }
    }
}
