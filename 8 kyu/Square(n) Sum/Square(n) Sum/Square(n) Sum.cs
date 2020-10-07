using System;

public static class Kata
{
    public static int SquareSum(int[] n)
    {
        double sum = 0;
        for (int i = 0; i < n.Length; i++)
        {
            sum += Math.Pow(n[i], 2);
        }
        return (int)sum;
    }
}