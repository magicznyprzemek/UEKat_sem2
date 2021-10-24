using System;

namespace sem2_3
{
    class Sprzedaz
    {
        public static int liczba_tranzakcji;
        public double cena, szt;
        public bool upust;
        public Sprzedaz(double shrek, double donkey, bool fiona)
        {
            cena = shrek;
            szt = donkey;
            upust = fiona;
            liczba_tranzakcji++;
        }
        public Sprzedaz(Sprzedaz klient)
        {
            cena = klient.cena;
            szt = klient.szt;
            upust = klient.upust;
            liczba_tranzakcji++;
        }

        public double Wartosc()
        {
            return cena * szt;
        }
        string Upust()
        {
            if(upust==true)
            {
                string x = " (przydzielono upust)";
                return x;
            }
            else
            {
                string f = " (nie przydzialono upust)";
                return f;
            }
        }
        public override string ToString()
        {
            string s1 =liczba_tranzakcji+ " - Wartosc: " + Wartosc()+ Upust();
            return s1;
        }
        public void Wyswietl()
        {
            Console.WriteLine(ToString());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Agregacja agregaty123 = new Agregacja(  new Sprzedaz(dodatki.Brutto(5,23), 10, true),
                                                    new Sprzedaz(4, 6, true),
                                                    new Sprzedaz(11, 5, false)  );
           Console.WriteLine( agregaty123.Suma() );

        }

    }
}
