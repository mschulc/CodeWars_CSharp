using System;

public static class Kata
{
    public static int TrailingZeros(int n)
    {
        int result = 0;
        for (int i = 5; n / i >= 1; i *= 5)
            result += n / i;
        return result;
    }
}
