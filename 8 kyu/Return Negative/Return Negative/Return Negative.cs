using System;

public static class Kata
{
    public static int MakeNegative(int number)
    {
        if (number > 0)
            return number * -1;
        else if (number < 0)
            return number;
        else
            return 0;
    }
}