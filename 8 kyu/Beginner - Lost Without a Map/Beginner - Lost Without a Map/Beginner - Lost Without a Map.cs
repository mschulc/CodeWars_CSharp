public class Kata
{
    public static int[] Maps(int[] x)
    {
        int[] maps = new int[x.Length];
        for (int i = 0; i < x.Length; i++)
        {
            maps[i] = 2 * x[i];
        }
        return maps;
    }
}