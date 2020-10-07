using System;
using System.Linq;
public class Kata
{
    public static int CalculateTip(double amount, string rating)
    {
        if (rating.ToLower() == "terrible")
            return (int)Math.Ceiling(amount * 0);
        else if (rating.ToLower() == "poor")
            return (int)Math.Ceiling(amount * 0.05);
        else if (rating.ToLower() == "good")
            return (int)Math.Ceiling(amount * 0.1);
        else if (rating.ToLower() == "great")
            return (int)Math.Ceiling(amount * 0.15);
        else if (rating.ToLower() == "excellent")
            return (int)Math.Ceiling(amount * 0.2);
        else
            return -1;
    }
}