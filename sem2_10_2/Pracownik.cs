using System;
using System.Collections.Generic;
using System.Text;

namespace sem2_10_2
{
    class Pracownik : IOsoba
    {
        public string miasto { get; set; }
        public string ulica { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public Pracownik(string m, string u, string i, string n)
        {
            miasto = m;
            ulica = u;
            Imie = i;
            Nazwisko = n;
        }
    }
}
