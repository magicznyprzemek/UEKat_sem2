using System;

namespace sem2_78_z2
{
    class Program
    {
        
        static void Main(string[] args)
        {

           
            //int
            int[] tab = new int[] { 1, 2, 3, 4, 5 };
            foreach (int x in tab)
            {
                // Console.Write(x+" ");
            }
            Console.WriteLine();
            Tasuj<int>(tab);
            foreach (int x in tab)
            {
                //  Console.Write(x + " ");
            }
            //kart
            karty[] talia_kart = new karty[3];
            talia_kart[0] = new karty("trefl", "walet");
            talia_kart[1] = new karty("pik", "dama");
            talia_kart[2] = new karty("karo", "król");

            Array.ForEach(talia_kart, kupa => { Console.WriteLine(kupa.ToString()); } );

            Tasuj<karty>(talia_kart);
            Console.WriteLine("-------------");
            Array.ForEach(talia_kart, kupa => { Console.WriteLine(kupa.ToString()); });


        }
        
        private static Random rng = new Random();
        public static void Tasuj<T>(T[] p)
        {
            int n = p.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T test = p[k];
                p[k] = p[n];
                p[n] = test;
            }
        }
    }
}
