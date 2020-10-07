using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int[] ExtraPerfect(int n)
    {
        double m = (double)n / 2;
        if (m - (int)m != 0)
            m += 1;
        List<int> list = new List<int>();
        int c = 1;
        for (int i = 0; i < Math.Floor(m); i++)
        {
            list.Add(c);
            c += 2;
        }
        return list.ToArray();
    }
}