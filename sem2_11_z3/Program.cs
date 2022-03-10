using System;
using System.IO;
using System.Collections.Generic;
using System.Reflection;

namespace sem2_11_z3
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly ass = Assembly.Load("Mscorlib");
            Type typ = ass.GetType("System.IO.Stream");
            MethodInfo[] tab = typ.GetMethods();
            var lista = PobierzM(tab);
            string path = @"C:\Users\Przemek\Desktop\wynik.csv";
            Zapisz(path, lista);


        }
        public static void Zapisz(string path2, List<Metoda> lista)
        {

            try
            {
                using (StreamWriter sw = new StreamWriter(path2, append: true))
                {
                    foreach (Metoda m in lista)
                    {
                        Console.WriteLine(m.ToCsv());
                        sw.WriteLine(m.ToCsv());
                    }

                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        static List<Metoda> PobierzM(MethodInfo[] tab)
        {
            List<Metoda> lista = new List<Metoda>();
            int i;
            foreach (MethodInfo m1 in tab)
            {
                if ((i = lista.FindIndex(i => i.Nazwa == m1.Name)) >= 0)
                {

                }
                else
                {
                    lista.Add(new Metoda
                    {
                        Nazwa = m1.Name,
                        Wirtualna = m1.IsVirtual,
                        Abstrakcyjna = m1.IsAbstract,
                        Zwraca = (m1.ReturnType).ToString(),
                        Argumenty = (m1.Attributes).ToString()


                    });
                }
            }
            return lista;
        }
    }
}
