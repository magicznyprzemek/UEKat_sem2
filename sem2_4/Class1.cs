using System;
using System.Collections.Generic;
using System.Text;

namespace sem2_4
{
    class Class1
    {
    }
}
namespace Cwiczenia3
{
    // zadanie 4
    public class Agregacja
    {
        private Sprzedaz s1, s2, s3;
        public Agregacja(Sprzedaz s1, Sprzedaz s2, Sprzedaz s3)
        {
            this.s1 = s1;
            this.s2 = s2;
            this.s3 = s3;
        }

        double Suma()
        {
            return s1.Wartosc + s2.Wartosc + s3.Wartosc;
        }

        double Srednia()
        {
            return Suma() / Sprzedaz.liczbaTransakcji;
        }

        public void Wyswietl()
        {
            Console.WriteLine($"Suma: {Suma()}, Średnia: {Srednia()}");
        }
    }
}
namespace Cwiczenia3
{
    static class Dodatki
    {
        public static double NettoNaBrutto(double cena, double podatekVat)
        {
            double VAT = Math.Round(cena * podatekVat / 100, 2);
            return cena + VAT;
        }

        public static double BruttoNaNetto(double cena, double podatekVat)
        {
            double VAT = Math.Round(cena * podatekVat / (podatekVat + 100), 2);
            return cena - VAT;
        }
    }
}

