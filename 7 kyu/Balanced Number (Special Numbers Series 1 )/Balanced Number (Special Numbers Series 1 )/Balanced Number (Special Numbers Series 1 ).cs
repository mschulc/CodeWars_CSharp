class Kata
{
    public static string BalancedNumber(int number)
    {
        string x = number.ToString();
        int left = 0;
        int right = 0;
        if (x.Length % 2 == 0)
        {
            for (int i = 0; i < (x.Length - 1) / 2; i++)
            {
                left = left + int.Parse(x[i].ToString());
            }
            for (int j = (x.Length + 2) / 2; j <= x.Length - 1; j++)
            {
                right = right + int.Parse(x[j].ToString());
            }
        }
        else if (x.Length == 1)
        {
            return "Balanced";
        }
        else if (x.Length % 2 != 0)
        {
            for (int i = 0; i < x.Length / 2; i++)
            {
                left = left + int.Parse(x[i].ToString());
            }
            for (int j = (x.Length / 2) + 1; j < x.Length; j++)
            {
                right = right + int.Parse(x[j].ToString());
            }
        }
        if (left == right)
        {
            return "Balanced";
        }
        else
        {
            return "Not Balanced";
        }
    }
}