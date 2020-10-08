using System;
using System.Numerics;

public class Kata
{
    public static string Add(string a, string b)
    {
        BigInteger sum;
        BigInteger.TryParse(a, out BigInteger x);
        BigInteger.TryParse(b, out BigInteger y);

        sum = x + y;
        return sum.ToString();
    }
}