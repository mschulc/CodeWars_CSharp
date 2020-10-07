using System;
using System.Collections.Generic;
using System.Text;

public class Carboat
{
    public static string howmuch(int m, int n)
    {
        List<int> M = new List<int>();
        List<int> C = new List<int>();
        List<int> B = new List<int>();
        int p = 0;
        int o = 0;
        if (n < m)
        {
            p = m;
            o = n;
        }
        else
        {
            p = n;
            o = m;
        }
        for (int i = Math.Abs(o); i <= Math.Abs(p); i++)
        {
            int c = (1 - i) / -9;
            int b = (2 - i) / -7;
            if (i - 7 * b == 2 && i - 9 * c == 1)
            {
                M.Add(i);
                C.Add(c);
                B.Add(b);
            }
        }
        StringBuilder text = new StringBuilder();
        text.Append("[");
        for (int i = 0; i < M.Count; i++)
        {
            text.Append("[M: ");
            text.Append(M[i].ToString());
            text.Append(" B: ");
            text.Append(B[i].ToString());
            text.Append(" C: ");
            text.Append(C[i].ToString());
            text.Append("]");
        }
        text.Append("]");
        return text.ToString();
    }
}
