using System;
using System.Collections.Generic;
using System.Text;

namespace sem2_3
{

  class Agregacja
    {
        Sprzedaz s1, s2, s3;
        public Agregacja(Sprzedaz t1, Sprzedaz t2, Sprzedaz t3)
        {
            s1 = t1;
            s2 = t2;
            s3 = t3;
        }
       public double Suma()
        {
            return s1.Wartosc() + s2.Wartosc() + s3.Wartosc();
        }
        public double Srednia()
        {
            return Suma() / Sprzedaz.liczba_tranzakcji;
        }
    }
       
}
