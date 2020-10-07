using System;

public class Kata
{
    public static char GetGrade(int s1, int s2, int s3)
    {
        int average = (s1 + s2 + s3) / 3;

        if (90 <= average)
            return 'A';
        else if (80 <= average)
            return 'B';
        else if (70 <= average)
            return 'C';
        else if (60 <= average)
            return 'D';
        else
            return 'F';
    }
}