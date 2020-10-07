using System;
using System.Collections.Generic;
using System.Linq;
public class LargestTwo
{
    public static int[] TwoOldestAges(int[] ages)
    {
        List<int> list = new List<int>();
        int[] tab = new int[2];
        for (int i = 0; i < ages.Length; i++)
        {
            list.Add(ages[i]);
        }
        tab[1] = list.Max();
        list.Remove(list.Max());
        tab[0] = list.Max();
        return tab;
    }
}