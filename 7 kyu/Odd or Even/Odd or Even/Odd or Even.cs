public class Kata
{
    public static string OddOrEven(int[] array)
    {
        int vec = 0;
        for (int i = 0; i < array.Length; i++)
        {
            vec += array[i];
        }
        if (vec % 2 == 0)
        {
            return "even";
        }
        else
        {
            return "odd";
        }
    }
}
