using System;
using System.Collections.Generic;
using System.Text;

namespace sem2_6_zad5
{
    class MacierzTr : Macierz
    {
        public MacierzTr(double[,] tab1) : base (tab1)
        {

        }
        public override double Wyznacznik()
        {
            double wyznacznik=tab1[0,0];
            
            for (int i = 1; i < tab1.GetLength(0); i++)
            {

                wyznacznik = wyznacznik * tab1[i, i];

                
            }

            return wyznacznik;
        }
        public override void Wyswietl()
        {
            for(int i=0; i<tab1.GetLength(0); i++)
            {
                for (int z = 0; z < tab1.GetLength(0); z++)
                {
                    Console.Write(tab1[i, z]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
