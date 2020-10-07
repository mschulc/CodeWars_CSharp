using System;
using System.Text;

public static class Kata
{
    public static string Solution(string str)
    {
        StringBuilder text = new StringBuilder();
        for (int i = str.Length - 1; i >= 0; i--)
        {
            text.Append(str[i]);
        }
        return text.ToString();
    }
}