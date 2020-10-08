using System;
using System.Text;

public class Kata
{
    public static string CreatePhoneNumber(int[] numbers)
    {
        StringBuilder pnumber = new StringBuilder();
        pnumber.Append("(");
        for (int i = 0; i <= 2; i++)
        {
            pnumber.Append(numbers[i]);
        }
        pnumber.Append(") ");
        for (int i = 3; i <= 5; i++)
        {
            pnumber.Append(numbers[i]);
        }
        pnumber.Append("-");
        for (int i = 6; i <= 9; i++)
        {
            pnumber.Append(numbers[i]);
        }
        return pnumber.ToString();
    }
}