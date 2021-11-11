using System;
using System.Collections.Generic;
using System.Text;

namespace sem2_10_2b
{
    interface IOsoba : IAdres
    {
        string Imie { get; set; }
        string Nazwisko { get; set; }
    }

}
