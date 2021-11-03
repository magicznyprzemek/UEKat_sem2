using System;
using System.Collections.Generic;
using System.Text;

namespace sem2_6_zad5
{
    abstract class Macierz
    {
        public double[,] tab1;
        public Macierz(double[,] tab)
        {
            tab1 = tab;
           
        }
           
        public abstract double Wyznacznik();
        public abstract void Wyswietl();
    }
}
