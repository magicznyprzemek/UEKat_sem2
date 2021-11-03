using System;

namespace sem2_6_z2
{
    class Program
    {
        static void Main(string[] args)
        {
            Figura[] test = new Figura[3];         
            test[0] = new Kolo(12);
            test[0].kolor = "czerwony";
            test[0].color = ConsoleColor.Red;
            test[1] = new Prostokat(5, 10);
            test[1].color = ConsoleColor.Yellow;
            test[2] = new Blat(4, 8, 250);
            test[2].color = ConsoleColor.Gray;
            
            foreach(Figura x in test)
            {

                Console.WriteLine(x.ToString());
            }
  
           
        }
    }
}
