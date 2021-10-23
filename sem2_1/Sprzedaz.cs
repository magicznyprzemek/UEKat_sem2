using System;
using System.Collections.Generic;
using System.Text;

namespace sem2_1
{
    class Prostokat
    {
        private double x;
        private double y;
        public Prostokat(double dl, double szr)
        {
            x = dl;
            y = szr;

        }
        private double Obwod()
        {
            return (x+y)*2;
        }
        private double Powierzchnia()
        {
            return x*y;
        }
        public override string ToString()
        {
            string s1 = "obwód: " + Obwod() + " Powierzchnia: " + Powierzchnia();
            return s1;
        }
        public static double Max(Prostokat[] tab)
        {
            double max = 0;
            foreach (Prostokat pr in tab)
            {
                if (pr.Powierzchnia() > max)
                {
                    max = pr.Powierzchnia();
                }
            }
            return max;
        }
    }

    class Sprzedaz
    {
        private double cena;
        private double upust;
        private const int szt = 10;

        public Sprzedaz(double price, double vent)
        {
            cena = price;
            upust = vent;
        }

        private double WartPrzed()
        {
            return cena*szt;
        }

        private double WartPo()
        {
            return WartPrzed() - (WartPrzed()*(upust));
        }
        public override string ToString()
        {
            string before = $"Wartość przed: cena: {WartPrzed():C};   upust: {upust:P}; sztuki: {szt}";
            string after = $"Wartość po: cena: {WartPo():C};   upust: {upust:P}; sztuki: {szt}";
            return before + Environment.NewLine + after;
            
        }
        public static double Min (Sprzedaz[] tab)
        {
            double min = Double.MaxValue;
            foreach(Sprzedaz sp in tab)
            {
                if(sp.WartPrzed()<min)
                {               
                    min = sp.WartPrzed();
                }
            }
            return min;
        }
    }

}
