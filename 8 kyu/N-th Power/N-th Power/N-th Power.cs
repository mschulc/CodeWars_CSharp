using System;
public class Kata
{
    public static double Index(int[] array, int n)
    {
        double score = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (i == n)
            {
                score = Math.Pow(array[n], n);
            }
            else if (i == array.Length - 1)
                break;
        }
        return score;
    }
}