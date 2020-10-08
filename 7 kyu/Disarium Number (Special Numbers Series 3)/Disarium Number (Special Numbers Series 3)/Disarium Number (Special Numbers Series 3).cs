using System;

class Kata
{
    public static string DisariumNumber(int number)
    {
        string x = number.ToString();
        double result = 0;
        for (int j = 0; j < x.Length; j++)
        {
            result = result + Math.Pow(int.Parse(x[j].ToString()), (j + 1));
        }
        if ((int)result == number)
        {
            return "Disarium !!";
        }
        else
        {
            return "Not !!";
        }
    }
}