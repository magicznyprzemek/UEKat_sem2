using System;
using System.Collections.Generic;
using System.Linq;

namespace sem2_12_z3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Miasto> lista = new List<Miasto>();
            lista.Add(new Miasto("Chorzów", 33.50, 108434));
            lista.Add(new Miasto("Tychy", 81.81, 128211));
            lista.Add(new Miasto("Katowice", 164.64, 294510));
            lista.Add(new Miasto("Bytom", 69.44, 166795));
            lista.Add(new Miasto("Gliwice", 133.88, 181309));
            zad_a(lista);
        }
        
        static void zad_a(List<Miasto> lista)
        {
            
            var A =
                lista.OrderByDescending(n => n.Ludnosc)
                .OrderBy(n => n.Pow)
                .First();
            var B =
                lista.Select(n => n)
                .OrderBy(n => n.Nazwa)
                .Where(n => (n.Nazwa != A.Nazwa));

            Console.WriteLine($"max pow: {Math.Round((A.Ludnosc / A.Pow),2)}");
              foreach(Miasto n in B)
            {
                Console.WriteLine(n.ToString());
            }
            
        }
        static void zad_c(List<Miasto> lista)
        {
            var test =
                lista.GroupBy(n => (n));//dok
               
        }
    }
}
