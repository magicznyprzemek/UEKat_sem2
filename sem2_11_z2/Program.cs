using System;
using System.IO;
using System.Collections.Generic;

namespace sem2_11_z2
{
    class Program
    {
        public static List<Pogoda> pogody = new List<Pogoda>();
        public enum Kierunek
        {
            wschód,
            zachód,
            północ,
            połódnie

        }
        public enum Zachmurzenie
        {
            duże,
            średnie,
            małe,
            brak
        }
        public static void Main()
        {

            string path1 = @"C:\Users\Przemek\Desktop\test.csv";
            los(1000, path1);
            czytaj(path1);

        }
        public static void czytaj(string path)
        {
            int brak_chmur = 0, wilgotnosc_80 = 0;
            int i = 0;
            string linia;
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while ((linia = sr.ReadLine()) != null)
                    {
                        string[] tab = linia.Split(';');
                        pogody.Add(new Pogoda());
                        pogody[i].czas = tab[0];
                        pogody[i].temp = tab[1];
                        pogody[i].pred = tab[2];
                        pogody[i].kier = tab[3];
                        pogody[i].wilg = tab[4];
                        pogody[i].zach = tab[5];
                        Console.WriteLine(pogody[i].write());
                        if (pogody[i].zach == "brak") { brak_chmur++; };
                        if (int.Parse(pogody[i].wilg) >= 80) { wilgotnosc_80++; };
                        i++;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("----------");
            Console.WriteLine("ilość bezchmurnych dni: " + brak_chmur);
            Console.WriteLine("ilość dni z wilgotnością 80% lub więcej: " + wilgotnosc_80);
        }
        public static void zapisz(string x, string path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path, append: true))
                {
                    sw.WriteLine(x);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static void los(int x, string path)
        {

            DateTime data = new DateTime(2020, 3, 1, 12, 0, 0);
            int xd = 0;
            Random rnd = new Random();
            Pogoda[] tab = new Pogoda[x];
            for (int i = 0; i < x; i++)
            {
                tab[i] = new Pogoda();
               // tab[i].czas = hour(xd);
                tab[i].czas = data.ToString();
                tab[i].temp = (rnd.Next(-2, 15).ToString());
                tab[i].pred = (rnd.Next(0, 45).ToString());
                tab[i].kier = ((Kierunek)rnd.Next(0, 4)).ToString();
                tab[i].wilg = $"{rnd.Next(0, 100)}";
                tab[i].zach = ((Zachmurzenie)rnd.Next(0, 4)).ToString();
                xd++;
                tab[i].write();
                zapisz(tab[i].ToString(), path);
                data = data.AddHours(1);
            }
        }
        public static string hour(int x) // alternatywna metoda obliczania daty
        {
            string data = null;
            int dni = x / 24;
            int godz = x % 24;
            int mies = dni / 30;
            dni = dni % 30;
            data = $"{godz}:00 {1 + dni}-{5 + mies}-2021";
            return data;
        }
    }
}
