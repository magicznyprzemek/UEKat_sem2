using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;

namespace sem2_10_4
{
    class kolory : IEnumerable
    {
        string[] teksty = null;
        public kolory(params string[] tabParam)
        {
            teksty = new string[tabParam.Length];
            int indeks = 0;
            foreach (string txt in tabParam)
            {
                teksty[indeks++] = txt;
            }
        }
        public IEnumerator GetEnumerator()
        {
            return teksty.GetEnumerator();
        }

    }
}
