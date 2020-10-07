using System;
using System.Linq;

public class Kata
{
    public static int[] DifferenceInAges(int[] ages)
    {
        int[] tab = new int[3];
        tab[0] = ages.Min();
        tab[1] = ages.Max();
        tab[2] = ages.Max() - ages.Min();
        return tab;
    }
}