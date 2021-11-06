using System;
using System.Collections.Generic;
using System.Text;

namespace sem2_10_1
{
    class Prostokat : IFigura
    {
        public ConsoleColor Kolor { get; set; }
        public double x, y;
        public Prostokat(double x1, double y2)
        {
            x = x1;
            y = y2;
        }
        public double Pole() => 2 * x + 2 * x;
        public override string ToString()
        {
            return $"PROSTOKĄT - Kolor: {Kolor} | Wymiary: {x}x{y} | Pole: {Pole()}";
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
