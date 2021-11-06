using System;
using System.Collections.Generic;
using System.Text;

namespace sem2_10_1
{
    class Kolo : IFigura
    {
        public ConsoleColor Kolor { get; set; }
        public double Promien;
        public Kolo(double x) => Promien = x;    
        public double Pole() => 3.14 * (Promien * Promien);
        public override string ToString()
        {
            return $"KOŁO - Kolor: {Kolor} | Promień: {Promien} | Pole: {Pole()}";
        }
        bool IComparable.CompareTo(IFigura x)
        {
            if (Pole() > x.Pole())
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
