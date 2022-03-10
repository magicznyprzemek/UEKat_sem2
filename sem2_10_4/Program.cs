using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace sem2_10_4
{
    class Program
    {
        static void Main(string[] args)
        {
            kolory k = new kolory("bialy", "czerwony", "zółty", "zielony", "czarny", "brązowy");
            foreach (string kolor in k)
            {
                Console.WriteLine(kolor);
            }
        }

    }
}
