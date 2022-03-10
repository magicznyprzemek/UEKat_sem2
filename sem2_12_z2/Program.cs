using System;
using System.Collections.Generic;
using System.Linq;

namespace sem2_12_z2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> biegacze = new List<string> { "Ania", "Tomek", "Jola", "Adam", "Jan" };
            List<string> plywacy = new List<string> { "Tomek", "Adam", "Robert", "Tomek" };
            // zad_a(biegacze, plywacy);
            // zad_b(biegacze, plywacy);
            zad_c(biegacze, plywacy);
        }
        static void zad_a(List<string> bieg, List<string> plyw)
        {
            var oba_sporty =
                bieg.Intersect(plyw);    
            foreach (string n in oba_sporty)
            {
                Console.Write(n + " ");
            }
        }
        static void zad_b(List<string> bieg, List<string> plyw)
        {
            var oba_sporty =
                bieg.Except(plyw);
            foreach (string n in oba_sporty)
            {
                Console.Write(n + " ");
            }
        }
        static void zad_c(List<string> bieg, List<string> plyw)
        {
            var oba_sporty =
                bieg.Concat(plyw)
                .GroupBy(n => (n.ToString().Last() == 'a'));
            
            foreach (IGrouping<bool, string> g in oba_sporty)
            {
                Console.WriteLine("--- " + g.Key);
                foreach (string z in g)
                {
                    Console.WriteLine(z + "<");
                }
            }
        }
    }
}
