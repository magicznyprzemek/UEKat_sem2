using System;
using System.Collections.Generic;
using System.Text;

namespace sem2_11_z2
{

    class Pogoda
    {
        public string czas { get; set; }
        public string temp { get; set; }
        public string pred { get; set; }
        public string kier { get; set; }
        public string wilg { get; set; }
        public string zach { get; set; }
        /*
        public Pogoda(string c, string t, string p, string k, string w, string z)
        {
            czas = c;
            temp = t;
            pred = p;
            kier = k;
            wilg = w;
            zach = z;
        }
        */
        public override string ToString()
        {
            return $"{czas};{temp};{pred};{kier};{wilg};{zach}";
        }
        public string write()
        {
            return $"{czas}\t {temp}C \t {pred}\t {kier}     \t {wilg}%\t {zach}";
        }
    }
}
