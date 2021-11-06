using System;

namespace sem2_78_4
{
    class Program
    {
        static void Main(string[] args)
        {
            auto[] tab=
            {
                new auto(1999, "skoda"),
                new auto(2000, "toyota"),
                new auto(2012, "ford"),
                new auto(2013, "ford 2")

            };
            compare<auto> comp = auto.compcar;
            sort(tab, comp);
            Array.ForEach(tab, x => { Console.WriteLine(x.ToString()); });
                
        }

        public delegate bool compare<T>(T x, T y);

        static void sort<T>(T[] arr, compare<T> comp) 
        {
            T temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (comp( arr[i], (arr[i + 1])))
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
        }
    }
}
