using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int[] DeleteNth(int[] arr, int x)
    {
        List<int> list = arr.ToList();
        for (int i = 1; i <= arr.Max(); i++)
        {
            int c = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                if (i == arr[j])
                {
                    c++;
                    if (c > x)
                    {
                        list.RemoveAt(list.LastIndexOf(i));
                    }
                }
            }
        }
        return list.ToArray();
    }
}