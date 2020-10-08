using System;
using System.Collections.Generic;

namespace Solution
{
    class Digitizer
    {
        public static long[] Digitize(long n)
        {
            string numer = n.ToString();
            long[] tab = new long[numer.Length];
            for (int i = 0; i < numer.Length; i++)
            {
                tab[i] = long.Parse(numer[i].ToString());
            }
            Array.Reverse(tab);
            return tab;
        }
    }
}