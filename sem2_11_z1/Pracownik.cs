using System;
using System.Collections.Generic;
using System.Text;

namespace sem2_11_z1
{
    class Pracownik
    {
        private string Imie;
        private string Nazwisko;
        private string Godziny;
        private string Stawka;
        public Pracownik(string i, string n, string g, string s)
        {
            Imie = i;
            Nazwisko = n;
            Godziny = g;
            Stawka = s;
        }
        public double Pensja() => double.Parse(Godziny) * double.Parse(Stawka);
        public override string ToString()
        {
            return $"{Imie} \t  { Nazwisko}  \t {Godziny}  \t {Stawka} \t  {Pensja()}";
        }
        public string Csv()
        {
            return $"{Imie};{Nazwisko};{Godziny};{Stawka};{Pensja()}";
        }

    }
}
