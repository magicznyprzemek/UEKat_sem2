using System;
using System.Collections.Generic;
using System.Text;


namespace sem2_78
{
    class Tablica <T>
    {
        public int indeks;
        public T wartosc;
        protected T[] tab = new T[2];
        
        public void wyswietl()
        {
            int xd = 0;
            foreach(T x in tab)
            {

                Console.WriteLine(xd+" "+x);
                xd++;
            }
        }
        public void wpisz(int x, T p)
        {
            indeks = x;
            wartosc = p;
            if (indeks > tab.Length - 1)
            {
                Array.Resize(ref tab, indeks + 1);
                tab[indeks] = wartosc;
            }
            else
            {
                tab[indeks] = wartosc;
            }
        }
    }
}
