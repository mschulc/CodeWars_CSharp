using System;

public class DivSeven
{
    public static long[] Seven(long m)
    {
        long[] tab = new long[2];
        string x = m.ToString();
        int c = 0;
        if (m > 10)
        {
            for (int i = x.Length - 1; i >= 0; i--)
            {
                string t = "";
                for (int j = 0; j < x.Length - 1; j++)
                {
                    t = t + x[j].ToString();
                }
                c++;
                x = (long.Parse(t) - (long.Parse(x[i].ToString()) * 2)).ToString();
                if (long.Parse(x) < 100 && long.Parse(x) % 7 == 0)
                    break;
                else if (long.Parse(x) < 100)
                    break;
            }
        }
        tab[0] = long.Parse(x);
        tab[1] = c;
        if (m == 0)
            return new long[] { 0, 0 };
        else if (m < 10 && m != 0)
            return new long[] { m, 0 };
        else
            return tab;
    }
}