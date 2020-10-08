using System;
using System.Numerics;
public static class Kata
{
    public static string sumStrings(string a, string b)
    {
        BigInteger sum;
        BigInteger.TryParse(a, out BigInteger x);
        BigInteger.TryParse(b, out BigInteger y);

        sum = x + y;

        return sum.ToString();
    }
}