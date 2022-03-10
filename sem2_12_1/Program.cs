using System;
using System.Linq;
using System.Collections.Generic;

namespace sem2_12_1
{
    class Program
    {
        static List<int> lista = new List<int>();
        static void Main(string[] args)
        {

            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                lista.Add((rnd.Next(0, 120)));
                Console.Write(lista[i] + " ");
            }

            // lista.Add(2); lista.Add(0); lista.Add(10); lista.Add(6); lista.Add(2);
            Console.WriteLine();
            // zad_a(lista);
            //zad_b(lista);
            zad_c(lista);

        }
        static void zad_a(List<int> lista)
        {
            IEnumerable<int> maks = from n in lista
                                    let maksimum = lista.Max()
                                    where (Math.Abs(maksimum - n) <= 25)
                                    orderby n descending
                                    select n;

            Console.WriteLine("max: " + lista.Max());
            foreach (int n in maks)
            {
                Console.Write(n + " ");
            }

        }
        static void zad_b(List<int> lista)
        {
            IEnumerable<int> minimum =
                lista.GroupBy(n => n)
                .Select(g => g.First())

                .OrderBy(n => n)
                .Take(3)
                .ToList();
            foreach (int n in minimum)
            {
                Console.Write(n + " ");
            }
        }
        static void zad_c(List<int> lista)
        {
            /*
            var ceilings = new[] { 10, 100 };
            IEnumerable<int> dzies =
                lista.Select(n=>n)
                .OrderBy(n=>n)
                .GroupBy(x=> item => ceilings.First(ceiling => ceiling >= item))
                */

            var ceilings = new[] { 9, 99, 999 };

            // var groupings = lista.GroupBy(item => ceilings.First(ceiling => ceiling >= item));
            var groupings =
                lista.OrderBy(n => n)
                .GroupBy(n => (n.ToString()).Length);

            foreach (IGrouping<int, int> g in groupings)
            {
                Console.WriteLine("--- " + g.Key);
                foreach (int z in g)
                {
                    Console.WriteLine(z + "-");
                }
            }

        }
    }
}
