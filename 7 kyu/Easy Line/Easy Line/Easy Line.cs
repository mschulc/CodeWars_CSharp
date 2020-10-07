using System;
using System.Numerics;
using System.Collections.Generic;

public class Easyline
{
    public static BigInteger Factorial(BigInteger x)
    {
        BigInteger f = 1;
        for (int i = 1; i <= x; i++)
        {
            f *= i;
        }
        if (x == 0)
            return 1;
        else
            return f;
    }
    public static BigInteger EasyLine(int n)
    {
        BigInteger sum = 0;
        List<BigInteger> list = new List<BigInteger>();
        for (int i = 0; i <= n; i++)
        {
            list.Add(Factorial(n) / (Factorial(i) * Factorial(n - i)));
        }
        for (int i = 0; i < list.Count; i++)
        {
            sum += (list[i] * list[i]);
        }
        return sum;
    }
}