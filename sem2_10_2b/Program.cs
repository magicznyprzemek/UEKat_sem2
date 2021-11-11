using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IOsoba> osoby = new List<IOsoba>
            { 
                new Pracownik("Damian","Charkiewicz","Białystok","Wyszyńskiego",25),
                new Pracownik("Jakub","Nowak","Wrocław","Smutna",2),
                new Klient("Agata","Krzykała","Jastrzębie-Zdrój","Turystyczna",39),
                new Klient("Jakub","Marzec","Jastrzębie-Zdrój","Wrocławska",12)
            };
            Druk<IOsoba> naklejki = new Druk<IOsoba>();
            foreach (IOsoba o in osoby)
            {
                naklejki.Drukuj(o);
                Console.WriteLine();
            }
            Console.WriteLine("Po jakiej właściwości chcesz posortować listę: ");
            Console.WriteLine("1 - imie\n2 - nazwisko\n3 - miasto\n4 - ulica");
            string cyfra = Console.ReadLine();
            List<IOsoba> sorted = osoby.ToList();
            if (cyfra == "1")
            {
                sorted = osoby.OrderBy(x => x.Imie).ToList();
            }
            else if (cyfra == "2")
            {
                sorted = osoby.OrderBy(x => x.Nazwisko).ToList();
            }
            else if (cyfra == "3")
            {
                sorted = osoby.OrderBy(x => x.Miasto).ToList();
            }
            else if (cyfra == "4")
            {
                sorted = osoby.OrderBy(x => x.Ulica).ToList();
            }
            else
            {
                Console.WriteLine("Nie ma takiego kryterium");
            }
            //List<IOsoba> sorted = osoby.OrderBy(x => x.Imie).ToList();
            foreach (IOsoba o in sorted)
            {
                naklejki.Drukuj(o);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}