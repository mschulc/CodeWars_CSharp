using System.Text;
public class Kata
{
    public static string DrawStairs(int n)
    {
        StringBuilder text = new StringBuilder();
        for (int i = 0; i < n; i++)
        {
            text.Append("I");
            if (i < n - 1)
            {
                text.Append("\n");
                for (int j = i; j >= 0; j--)
                {
                    text.Append(" ");
                }
            }
        }
        if (n == 1)
            return "I";
        else
            return text.ToString();
    }
}