public class Kata
{
    public static int SumMix(object[] x)
    {
        int sum = 0;
        for (int i = 0; i < x.Length; i++)
        {
            sum += int.Parse(x[i].ToString());
        }
        return sum;
    }
}
