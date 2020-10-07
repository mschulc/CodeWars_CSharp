public class Kata
{
    public static int[] GenerateRange(int min, int max, int step)
    {
        int count = ((max - min) / step) + 1;
        int[] tab = new int[count];

        int s = min;
        tab[0] = min;
        for (int i = 1; i < count; i++)
        {
            s += step;
            tab[i] = s;
        }
        return tab;
    }
}