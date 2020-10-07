using System;
public static class Kata
{
    public static int СenturyFromYear(int year)
    {
        decimal century = (decimal)year / 100;
        if (year <= 100)
            return 1;
        else if (century > Math.Floor((decimal)century))
            return (int)Math.Floor((decimal)century) + 1;
        else
            return (int)Math.Floor(century);
    }
}