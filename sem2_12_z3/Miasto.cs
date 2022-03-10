using System;
using System.Collections.Generic;
using System.Text;

namespace sem2_12_z3
{
    class Miasto
    {
        public string Nazwa { get; set; }
        public double Pow { get; set; }
        public int Ludnosc { get; set; }
        public Miasto(string n, double p, int l)
        {
            Nazwa = n;
            Pow = p;
            Ludnosc = l;
        }
        public override string ToString()
        {
            return $"{Nazwa}     \t {Pow}     \t {Ludnosc}";
        }
    }
}
