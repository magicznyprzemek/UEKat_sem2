using System;

namespace sem2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Prostokat p1 = new Prostokat(5, 10);
            Blat b1 = new Blat(2, 6, 600);
            Console.WriteLine(p1.ToString());
            Console.WriteLine(b1.ToString());
        }
    }
}
