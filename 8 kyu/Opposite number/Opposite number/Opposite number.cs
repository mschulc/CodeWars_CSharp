using System;

public class Kata
{
    public static int Opposite(int number)
    {
        if (number == 0)
            return 0;
        else
            return number - (number * 2);
    }
}