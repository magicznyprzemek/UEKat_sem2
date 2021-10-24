using System;
using System.Collections.Generic;
using System.Text;

namespace sem2_3
{
    class dodatki
    {
        public static double Brutto (double netto, int stawka)
        {
            double kwota = (netto * stawka) / 100;
            return Math.Round(netto + kwota, 2);
        }
        public static double Netto (double Brutto, int stawka)
        {
            double kwota = (Brutto * stawka) / (stawka+100);
            return Math.Round(Brutto - kwota, 2);
        }
    }
}
