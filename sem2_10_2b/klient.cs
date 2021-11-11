using System;
using System.Collections.Generic;
using System.Text;

namespace sem2_10_2b
{
    class Klient : IOsoba
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Miasto { get; set; }
        public string Ulica { get; set; }
        public int Numer { get; set; }
        public Klient(string imie, string nazwisko, string miasto, string ulica, int numer)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Miasto = miasto;
            Ulica = ulica;
            Numer = numer;
        }
    }
}
