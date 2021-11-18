using System;
using System.Collections.Generic;
using System.Text;

namespace sem2_10_3
{
    class DyrektorNaczelny : Pracownik
    {
        public double kwota_s;
        public DyrektorNaczelny(string naz, string im, double pp, double ks) : base(naz, im, pp) { kwota_s = ks; }
        public override double Premia()
        {
            return base.Premia() * 2+kwota_s;
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
