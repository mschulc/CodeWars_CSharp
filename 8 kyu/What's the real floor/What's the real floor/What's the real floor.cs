using System;

public static class Kata
{
    public static int GetRealFloor(int n)
    {
        if (n >= 14)
            return n - 2;
        else if (n >= 1)
        {
            return n - 1;
        }
        else
            return n;
    }
}