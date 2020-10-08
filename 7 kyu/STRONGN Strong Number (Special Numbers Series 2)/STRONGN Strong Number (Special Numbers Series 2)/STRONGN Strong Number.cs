class Kata
{
    public static string StrongNumber(int number)
    {
        string x = number.ToString();
        int result = 0;
        int score = 0;

        for (int j = 0; j < x.Length; j++)
        {
            if (int.Parse(x[j].ToString()) == 0 || int.Parse(x[j].ToString()) == 1)
            {
                result = 1;
            }
            else if (int.Parse(x[j].ToString()) > 1)
            {
                result = int.Parse(x[j].ToString());
                for (int k = 1; k < int.Parse(x[j].ToString()); k++)
                {
                    result = result * k;
                }
            }
            score = score + result;
        }
        if (score == number)
        {
            return "STRONG!!!!";
        }
        else
        {
            return "Not Strong !!";
        }
    }
}