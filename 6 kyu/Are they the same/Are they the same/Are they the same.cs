using System;
using System.Collections.Generic;
class AreTheySame
{
    public static bool comp(int[] a, int[] b)
    {
        bool comp = true;
        if (a is null || b is null)
        {
            comp = false;
        }
        else if (a.Length != b.Length)
        {
            comp = false;
        }
        else
        {
            Array.Sort(a);
            Array.Sort(b);
        }

        for (int i = 0; i < a.Length - 1; i++)
        {
            if (int.Parse(b[i].ToString()) != (int)Math.Pow(int.Parse(a[i].ToString()), 2))
            {
                comp = false;
                break;

            }
        }
        return comp;
    }
}