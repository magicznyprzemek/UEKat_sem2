using System;

namespace sem2_6_z4
{
    class Program
    {
        static void Main(string[] args)
        {
            Szescian[] tab = new Szescian[3];
            tab[0] = new Szescian(5);
            tab[1] = new Szescian(10, "klocek");          
            tab[2] = new Prostopadloscian(2, 2, 2);
            foreach(Szescian f in tab)
            {
                Console.WriteLine(f.ToString());
            }
        }
    }
}
