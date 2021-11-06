using System;

namespace sem2_10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            IFigura[] tab = new IFigura[3];
            tab[0] = new Kolo(5);
            tab[0].Kolor = ConsoleColor.Red;
            tab[1] = new Kolo(10);
            tab[1].Kolor = ConsoleColor.Green;
            tab[2] = new Prostokat(3, 5);
            tab[2].Kolor = ConsoleColor.Cyan;
            Drukuj(tab);
            Console.WriteLine("------------");
            sort(tab);
            Drukuj(tab);
        }
        static void Drukuj<T>(T[] tab)
        {
            Array.ForEach(tab, x => Console.WriteLine(x.ToString()));
        }
        static void sort(IFigura[] arr)
        {
            IFigura temp;
            for (int j = 0; j <= arr.Length - 2; j++)            
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i].CompareTo(arr[i + 1]))
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }          
        }
    }
}
