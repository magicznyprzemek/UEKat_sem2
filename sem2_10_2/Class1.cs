using System;
using System.Collections.Generic;
using System.Text;

namespace sem2_10_2
{
    class KlasaGeneryczna<T> where T : IOsoba
    {
        public void wyswietl(IOsoba x)
        {
            Console.WriteLine(x.Imie);
            Console.WriteLine(x.Nazwisko);
            Console.WriteLine(x.ulica);
            Console.WriteLine(x.miasto);
            Console.WriteLine();
        }
    }
}
