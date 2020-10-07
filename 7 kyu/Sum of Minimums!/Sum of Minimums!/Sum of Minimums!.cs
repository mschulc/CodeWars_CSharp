using System;

class Kata
{
    public static int SumOfMinimums(int[,] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            int a = 0;
            a = numbers[i, 0];
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                if (a > numbers[i, j])
                {
                    a = numbers[i, j];
                }
            }
            sum += a;
        }
        return sum;
    }
}