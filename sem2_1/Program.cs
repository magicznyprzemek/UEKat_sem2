using System;

namespace sem2_1
{
 
    class Program
    {
       public static void Main()
       {
            /*
            Sprzedaz[] tab = { new Sprzedaz(12, 0.2),
                               new Sprzedaz(65, 0.7),
                               new Sprzedaz(65, 0.3),};
            foreach(Sprzedaz sp in tab)
            {
               // Console.WriteLine(sp.ToString());     //z1/2
            }
           // Console.WriteLine(Sprzedaz.Min(tab)); // z3
            */
            //----------------------------

            //zd1
            
            Prostokat[] tab = {
                new Prostokat(12, 3),
                new Prostokat(100, 37),
                new Prostokat(10, 6)
                                };
            foreach(Prostokat pr in tab)
            {
                Console.WriteLine(pr.ToString());
                
            }
            Console.WriteLine(Prostokat.Max(tab));



        }
    }
}
