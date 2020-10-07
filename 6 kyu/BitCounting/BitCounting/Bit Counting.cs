using System;
using System.Text;

public class Kata
{
    public static string Binar(int x)
    {
        StringBuilder text1 = new StringBuilder();

        
        int[] tab = new int[] { 1073741824, 536870912, 268435456, 134217728, 67108864, 33554432, 16777216, 8388608, 4194304, 2097152, 1048576, 524288, 262144, 131072, 65536, 32768, 16384, 8192, 4096, 2048, 1024, 512, 256, 128, 64, 32, 16, 8, 4, 2, 1 };
        int k = x;
        for (int i = 0; i < tab.Length; i++)
        {
            if (k >= tab[i])
            {
                k -= tab[i];
                text1.Append("1");
            }
            else
            {
                text1.Append("0");
            }
        }
        return text1.ToString();
    }
    public static int CountBits(int n)
    {
        string binary = Binar(n);
        int x = 0;
        for (int i = 0; i < binary.Length; i++)
        {
            if (binary[i] == '1')
            {
                x++;
            }
        }
        return x;
    }
}