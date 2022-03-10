using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace sem2_11_z1
{
    class Pracownicy
    {
        public static List<Pracownik> lista = new List<Pracownik>();
        public void Read(string path)
        {
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string linia = null;
                    while ((linia = sr.ReadLine()) != null)
                    {
                        string[] tab = linia.Split(';');
                        lista.Add(new Pracownik(tab[0], tab[1], tab[2], tab[3]));
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void Write()
        {
            Console.WriteLine($"Imie\t  Nazwisko\tGodziny\t Stawka\t Pensja");
            for (int i = 1; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i].ToString());
            }
        }
        public void Zapisz(string path2)
        {

            try
            {
                using (StreamWriter sw = new StreamWriter(path2, append: true))
                {
                    sw.WriteLine($"Imie;Nazwisko;Godziny;Stawk;Pensja");
                    for (int i = 1; i < lista.Count; i++)
                    {
                        sw.WriteLine(lista[i].Csv());
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
