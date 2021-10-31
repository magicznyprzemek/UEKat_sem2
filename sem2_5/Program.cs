using System;
using System.IO;
using System.Collections.Generic;

namespace sem2_5
{
    public struct Ulamki
    {
        
        public string x, y;
        public Ulamki(string p1, string p2)
        {
            x = p1;
            y = p2;

        }
        public double Dziel(string ulam)
        {
            string[] dziel = ulam.Split('/');
            double r = Convert.ToDouble(dziel[0]) / Convert.ToDouble(dziel[1]);
            return r;

        }
        public double sum()
        {
           return (Dziel(x) + Dziel(y));
        }
    }
    class Program
    {         
        static void Main(string[] args)
        {
            
            string linia = Console.ReadLine().ToString();
            string[] ulamki = linia.Split('+', '=');
            Console.Write("{0}+{1}= ", ulamki[0], ulamki[1]);
            Ulamki a = new Ulamki(ulamki[0], ulamki[1]);
            Console.Write(a.sum());

            

        }
    }
}
