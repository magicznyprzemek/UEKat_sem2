using System;
using System.Collections.Generic;
using System.Text;

namespace sem2_10_3
{
    class Pracownik : IPremia
    {
        public string nazwisko { get; set; }
        public string imie;
        public double podstawaPremii { get; set; }

        public Pracownik(string naz, string im, double pp)
        {
            nazwisko = naz;
            imie = im;
            podstawaPremii = pp;
        }
        public virtual double Premia() => podstawaPremii * 0.1;
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
