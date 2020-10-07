using System;
public static class Clock
{
    public static int Past(int h, int m, int s)
    {
        int count = ((((h * 60) + m) * 60) + s) * 1000;
        return count;
    }
}