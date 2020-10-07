using System;

public class Persist
{
    public static int Persistence(long n)
    {
        string g = n.ToString();
        int c = 0;
        while (g.Length > 1)
        {
            long x = 1;
            for (int i = 0; i < g.Length; i++)
            {
                x *= long.Parse(g[i].ToString());
            }
            g = x.ToString();
            c++;
        }
        return c;
    }
}