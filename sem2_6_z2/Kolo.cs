using System;
using System.Collections.Generic;
using System.Text;

namespace sem2_6_z2
{
    class Kolo : Figura
    {
        public Double x;

        public Kolo(double promien)
        {
            x = promien;
        }

        public override double Pole()
        {
            return 3.14 * (x*x);
        }
        public override string ToString()
        {
            return base.ToString()+$"| Promien: {x} | Pole koła: {Pole()}";
        }
    }
}
