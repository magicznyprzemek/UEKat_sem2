using System;
using System.Collections.Generic;
using System.Text;

namespace sem2_10_3
{
    class Dyrektor : Pracownik
    {
        public Dyrektor(string naz, string im, double pp) : base(naz, im, pp) { }
        public override double Premia()
        {
            return base.Premia() * 2;
        }
        public int CompareTo(IPremia p)
        {
            if (p == null)
            {
                return 1;
            }
            else
            {
                return nazwisko.CompareTo(p.nazwisko);
            }
        }
    }
}
