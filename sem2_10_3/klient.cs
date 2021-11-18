using System;
using System.Collections.Generic;
using System.Text;

namespace sem2_10_3
{
    class Klient
    {
        // Klasa Klient nie implementuje interfejsu IPremia
        string nazwisko;
        string imie;
        public Klient(string naz, string im)
        {
            nazwisko = naz;
            imie = im;
        }

    }
}
