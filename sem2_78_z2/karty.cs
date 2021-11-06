using System;
using System.Collections.Generic;
using System.Text;

namespace sem2_78_z2
{
    class karty
    {
        string kolor, karta;
        public karty(string ko, string ka)
        {
            kolor = ko;
            karta = ka;
        }
        public override string ToString()
        {
            return $"{kolor} {karta}";
        }
    }
}
