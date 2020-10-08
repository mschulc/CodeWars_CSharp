public class Kata
{
    public static int[] MoveZeroes(int[] arr)
    {
        int[] tab = new int[arr.Length];
        int c = 0;
        foreach (int element in arr)
        {
            if (element != 0)
                tab[c++] = element;
        }
        return tab;
    }
}
