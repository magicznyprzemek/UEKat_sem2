using System;

namespace sem2_6_zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] test = new double[,] { { 2, 1 }, { 3, 7 } };
            double[,] test2 = new double[,] { { 1, 0 }, { 0, 1 } };
            MacierzTr test1 = new MacierzTr(test);
            MacierzJed test3 = new MacierzJed(test2);
            test1.Wyswietl();
            Console.WriteLine("--");
            Console.WriteLine(test1.Wyznacznik());
            Console.WriteLine("------------");
            test3.Wyswietl();
            Console.WriteLine("--");
            Console.WriteLine(test3.Wyznacznik());



        }
    }
}
