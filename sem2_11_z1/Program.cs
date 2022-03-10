using System;

namespace sem2_11_z1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Przemek\Desktop\progr\pracownicy.csv"; // lokalizajca plików była ustawiona z myślą o preznetacji na ćwiczeniach (szybszy dostęp do pulpitu)
            string path2 = @"C:\Users\Przemek\Desktop\pracownicy_wynik.csv";
            Pracownicy test = new Pracownicy();
            test.Read(path);  
            test.Write();
            test.Zapisz(path2);
        }
    }
}
