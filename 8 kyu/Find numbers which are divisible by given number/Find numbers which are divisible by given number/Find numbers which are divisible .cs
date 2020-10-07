public class Kata
{
    public static int[] DivisibleBy(int[] numbers, int divisor)
    {
        int n = 0;
        int a = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % divisor == 0)
            {
                n++;
            }
        }
        int[] tab = new int[n];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % divisor == 0)
            {
                tab[a] = numbers[i];
                a++;
            }
        }
        return tab;
    }
}
