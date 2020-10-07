using System;
using System.Linq;

namespace Solution
{
    class Kata
    {
        public static int find_it(int[] seq)
        {
            int x = -1;
            for (int i = 0; i <= seq.Max(); i++)
            {
                int c = 0;
                for (int j = 0; j < seq.Length; j++)
                {
                    if (i == seq[j])
                        c++;
                }
                if (c % 2 != 0)
                    x = i;
            }
            return x;
        }
    }
}