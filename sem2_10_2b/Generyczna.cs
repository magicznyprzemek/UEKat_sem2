using System;
using System.Collections.Generic;
using System.Text;

namespace sem2_10_2b
{
    class Druk<T> where T : IOsoba
    {
        public void Drukuj(IOsoba o)
        {
            Console.WriteLine("------------------");
            Console.WriteLine($"{o.Miasto}");
            Console.WriteLine($"{o.Ulica}");
            Console.WriteLine($"{o.Numer}");
            Console.WriteLine($"{o.Nazwisko}, {o.Imie}");
            Console.WriteLine("------------------");
        }
    }

}
