using System;
using System.Numerics;

class Kata
{
    public static string JumpingNumber(BigInteger number)
    {
        string digits = number.ToString();
        string result = "Not!!";
        if (digits.Length == 1)
        {
            result = "Jumping!!";
        }
        else
        {
            for (int i = 1; i < digits.Length; i++)
            {
                int wynik = int.Parse(digits[i - 1].ToString()) - int.Parse(digits[i].ToString());
                if (Math.Abs(wynik) != 1)
                {
                    result = "Not!!";
                    break;
                }
                else
                {
                    result = "Jumping!!";
                }
            }
        }
        return result;
    }
}