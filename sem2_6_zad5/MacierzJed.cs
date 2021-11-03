using System;
using System.Collections.Generic;
using System.Text;

namespace sem2_6_zad5
{
    class MacierzJed : Macierz
    {
        public MacierzJed (double[,] tab) : base (tab)
        {

        }
        public override double Wyznacznik()
        {
            return 1;
        }
        public override void Wyswietl()
        {
            for (int i = 0; i < tab1.GetLength(0); i++)
            {
                for (int z = 0; z < tab1.GetLength(0); z++)
                {
                    Console.Write(tab1[i, z] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
