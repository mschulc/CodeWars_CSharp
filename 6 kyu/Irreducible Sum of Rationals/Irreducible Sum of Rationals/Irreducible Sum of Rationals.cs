using System;
using System.Text;
using System.Numerics;
public class SumFractions
{
    public static string SumFracts(int[,] l)
    {
        BigInteger[] b = new BigInteger[2];
        if (l.Length > 0)
        {
            b[0] = l[0, 0];
            b[1] = l[0, 1];
        }
        for (int i = 1; i < l.GetLength(0); i++)
        {
            b[0] = (b[0] * l[i, 1]) + (b[1] * l[i, 0]);
            b[1] = b[1] * l[i, 1];
        }

        BigInteger x = b[0];
        BigInteger y = b[1];
        if (y != 0)
        {
            BigInteger p = BigInteger.GreatestCommonDivisor(x, y);
            x /= p;
            y /= p;
        }
        StringBuilder k = new StringBuilder();
        if (y == 1)
            k.Append(x.ToString());
        else
        {
            k.Append("[");
            k.Append(x.ToString());
            k.Append(", ");
            k.Append(y.ToString());
            k.Append("]");
        }
        if (l.Length == 0)
            return null;
        else
            return k.ToString();
    }
}
