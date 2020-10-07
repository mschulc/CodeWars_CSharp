public class Kata
{
    public static int[] Arr(int N)
    {
        int[] tab = new int[N];

        for (int i = 0; i < tab.Length; i++)
        {
            tab[i] = i;
        }
        return tab;
    }
}