public class Kata
{
    public static int[] Between(int a, int b)
    {
        int[] between = new int[(b - a) + 1];
        int c = a;
        for (int i = 0; i < between.Length; i++)
        {
            between[i] = c;
            c++;
        }
        return between;
    }
}
