using System;
using System.Collections.Generic;
using System.Text;

namespace sem2_10_1
{
    interface IFigura : IComparable
    {
        ConsoleColor Kolor { get; set; }
        double Pole();

    }
}
