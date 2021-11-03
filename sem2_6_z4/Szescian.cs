using System;
using System.Collections.Generic;
using System.Text;

namespace sem2_6_z4
{
    class Szescian
    {
        protected double krawedz;
        protected string nazwa { get; set; }
        
        public Szescian(double x, string naz = "*sześcian*")
        {
            krawedz = x;
            nazwa = naz;          
        }
        virtual public double obj()
        {
            return (krawedz*krawedz)*krawedz;
        }
        public override string ToString()
        {
            return $"Nazwa: {nazwa} | Krawędź: {krawedz} | Objętość: {obj()} ";
        }
    }
}
