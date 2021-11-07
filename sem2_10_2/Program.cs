using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem2_10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IOsoba> lista = new List<IOsoba>
            {
                new Klient("Mielno", "ul. Zupna", "Krzysztof", "Jem"),
                new Klient("Bagno", "brak ulicy", "shrek", "nieznane"),
                new Pracownik("Zakopane", "ul. Jana Pawła II", "Elon", "Piżmo")

            };
           
            KlasaGeneryczna<IOsoba> druk= new KlasaGeneryczna<IOsoba>();
            Console.WriteLine("Sposób sortowania: ");
            Console.WriteLine("1. Imie");
            Console.WriteLine("2. Nazwisko");
            Console.WriteLine("3. Miasto");
            Console.WriteLine("4. Ulica");
            
            string key = (Console.ReadKey()).ToString();
            if (key == "1")
            {
                lista = lista.OrderBy(x => x.Imie).ToList();
            }
            else if(key=="2")
            {
                lista = lista.OrderBy(x => x.Nazwisko).ToList();
            }
            else if (key == "3")
            {
                lista = lista.OrderBy(x => x.miasto).ToList();
            }
            else if (key == "4")
            {
                lista = lista.OrderBy(x => x.ulica).ToList();
            }
            //lista = lista.OrderBy(x => x.miasto).ToList();
            Console.Clear();
            Console.WriteLine("---------------");
            Console.WriteLine();
            foreach (IOsoba x in lista)
            {
                druk.wyswietl(x);
            }      
        }  
    }
}
