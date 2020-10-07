using System;

public static class Kata
{
    public static int summation(int num)
    {
        int score = 0;
        for (int i = 1; i <= num; i++)
        {
            score += i;
        }
        return score;
    }
}