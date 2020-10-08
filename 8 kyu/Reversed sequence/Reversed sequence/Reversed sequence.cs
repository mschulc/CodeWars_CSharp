using System;

public static class Kata
{
    public static int[] ReverseSeq(int n)
    {
        int[] tab = new int[n];

        for (int i = 0; i < n; i++)
        {
            tab[i] = n - i;
        }
        return tab;
    }
}