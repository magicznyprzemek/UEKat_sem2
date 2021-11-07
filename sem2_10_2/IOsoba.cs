using System;
using System.Collections.Generic;
using System.Text;

namespace sem2_10_2
{
    interface IOsoba : IAdres
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
    }
}
