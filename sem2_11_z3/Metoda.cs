using System;
using System.Collections.Generic;
using System.Text;


namespace sem2_11_z3
{
    class Metoda
    {
        public string Nazwa { get; set; }
        public bool Wirtualna { get; set; }
        public bool Abstrakcyjna { get; set; }
        public string Zwraca { get; set; }
        public string Argumenty { get; set; }
        public string ToCsv()
        {
            return $"{Nazwa};{Wirtualna};{Abstrakcyjna};{Zwraca};{Argumenty}";
            
        }
        
    }
}
