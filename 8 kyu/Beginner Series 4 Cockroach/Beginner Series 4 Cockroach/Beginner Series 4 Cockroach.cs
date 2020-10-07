using System;
public class Cockroach
{
    public static int CockroachSpeed(double x)
    {
        double score = x * 1000 / 36;
        return (int)Math.Floor(score);
    }
}