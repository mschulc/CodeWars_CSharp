using System;
using System.Text;

public class Kata
{
    public static string Remove_char(string s)
    {
        StringBuilder text = new StringBuilder();

        for (int i = 1; i < s.Length - 1; i++)
        {
            text.Append(s[i]);
        }
        return text.ToString();
    }
}