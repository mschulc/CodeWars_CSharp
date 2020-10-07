using System;
using System.Text;

public class Kata
{
    public string Pattern(int n)
    {
        StringBuilder text = new StringBuilder();

        for (int i = 1; i <= n; i++)
        {
            for (int j = n; j >= i; j--)
            {
                text.Append(j);
            }
            if (i != n)
                text.Append("\n");
        }
        return text.ToString();
    }
}
