using System;

namespace sem2_78
{
    class Program
    {
        static void Main(string[] args)
        {
            //z1
            Tablica<string> tab1 = new Tablica<string>();
            tab1.wpisz(0, "test");
            tab1.wpisz(1, "test2");
            tab1.wpisz(5, "test3");
            tab1.wyswietl();

        }

    }
}
