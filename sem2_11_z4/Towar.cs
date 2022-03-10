using System;
using System.Xml.Serialization;

namespace Zadanie_6_5
{
    public class Towar
    {
        //[XmlAttribute("Nazwa")]
        public string Nazwa { get; set; }
        public double Cena { get; set; }
        public double Ilosc { get; set; }

        public Towar(string n1, double c1, double il)
        {
            Nazwa = n1;
            Cena = c1;
            Ilosc = il;
        }
        // konstruktor domyślny konieczny dla serializacji
        public Towar() { }
    }
}