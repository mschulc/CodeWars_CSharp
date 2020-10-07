public class Kata
{
    public static string Sabb(string x, int val, int happ)
    {
        int letter = 0;
        string y = x.ToLower();
        for (int i = 0; i < y.Length; i++)
        {
            if (y[i] == 's' || y[i] == 'a' || y[i] == 'b' || y[i] == 't' || y[i] == 'i' || y[i] == 'c' || y[i] == 'l')
                letter++;
        }
        int sum = letter + val + happ;

        if (sum > 22)
            return "Sabbatical! Boom!";
        else
            return "Back to your desk, boy.";
    }
}