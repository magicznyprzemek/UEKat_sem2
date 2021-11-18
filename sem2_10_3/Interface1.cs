using System;
using System.Collections.Generic;
using System.Text;

namespace sem2_10_3
{
    interface IPremia : IComparable<IPremia>
    {
        double Premia();
        public double podstawaPremii { get; set; }      
        public string nazwisko { get; set; }
    }
}
