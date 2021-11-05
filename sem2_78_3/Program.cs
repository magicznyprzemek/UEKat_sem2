using System;

namespace sem2_78_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] tab1 = { 1, 4, 2.3, 0.2, 10 };
            int[] tab2 = { 3, 5, 2, 10 };       
            sort(tab1);
            sort(tab2);
            Array.ForEach(tab1, x => { Console.Write(x + " "); });
            Console.WriteLine();
            Array.ForEach(tab2, x => { Console.Write(x + " "); });

        }

        static void sort<T>(T[] arr) where T : IComparable
        {
            T temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i].CompareTo(arr[i + 1])>0)
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
