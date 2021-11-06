using System;
using System.Collections.Generic;
using System.Text;

namespace sem2_78_4
{
    class auto
    {
        public int rok;
        public string nazwa;
        public auto(int x, string n)
        {
            rok = x;
            nazwa = n;
        }
        public static bool compcar(auto t1, auto t2)
        {
            if(t1.rok>=t2.rok)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return $"{rok}  {nazwa}";
        }


    }
}
