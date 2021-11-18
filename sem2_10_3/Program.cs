using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem2_10_3
{
    class Program
    {
        static void Main()
        {
            IPremia[] tab = { new Pracownik("Nowak", "Jan", 10000) as IPremia,
                              new DyrektorNaczelny("Zbigniew", "Stonoga", 10000, 1000) as IPremia,
                              new Dyrektor("Kowalski", "Adam", 10000) as IPremia,
                              new Klient("Testowy", "Tomasz") as IPremia
                              
            };
            /*
            foreach (IPremia i1 in tab)
            {
                if (i1 != null)
                {
                    Console.WriteLine($"{i1.GetType().Name} {i1.Premia()}");
                }
            }
            */
            List<IPremia> sort = tab.ToList();
           
            sort.Sort(); // tak wiem - masło maślane
         
            foreach (IPremia x in sort)
            {
                if (x != null)
                    Console.WriteLine($"{x.nazwisko}: {x.Premia()} PLN");

            }
        }
        
      
    }
}
