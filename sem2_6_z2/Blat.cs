using System;
using System.Collections.Generic;
using System.Text;

namespace sem2_6_z2
{
    class Blat : Prostokat
    {
        double z;
        public Blat(double x, double y, double z1) : base(x, y)
        {
            z = z1;
        }
        
        public double cena()
        {
            return base.Pole() * z;
        }
        public override string ToString()
        {
            return base.ToString() + $" | Cena: {cena()}";
        }

    }
}
