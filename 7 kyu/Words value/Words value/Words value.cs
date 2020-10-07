using System;
using System.Collections.Generic;


public class Kata
{
    public static int[] WordValue(string[] a)
    {
        int[] result = new int[a.Length];
        Dictionary<string, int> alphabet = new Dictionary<string, int>();
        alphabet.Add("a", 1);
        alphabet.Add("b", 2);
        alphabet.Add("c", 3);
        alphabet.Add("d", 4);
        alphabet.Add("e", 5);
        alphabet.Add("f", 6);
        alphabet.Add("g", 7);
        alphabet.Add("h", 8);
        alphabet.Add("i", 9);
        alphabet.Add("j", 10);
        alphabet.Add("k", 11);
        alphabet.Add("l", 12);
        alphabet.Add("m", 13);
        alphabet.Add("n", 14);
        alphabet.Add("o", 15);
        alphabet.Add("p", 16);
        alphabet.Add("q", 17);
        alphabet.Add("r", 18);
        alphabet.Add("s", 19);
        alphabet.Add("t", 20);
        alphabet.Add("u", 21);
        alphabet.Add("v", 22);
        alphabet.Add("w", 23);
        alphabet.Add("x", 24);
        alphabet.Add("y", 25);
        alphabet.Add("z", 26);

        for (int i = 0; i < a.Length; i++)
        {
            int value = 0;
            for (int j = 0; j < a[i].Length; j++)
            {
                value += alphabet.GetValueOrDefault(a[i][j].ToString().ToLower()) * (i + 1);
            }
            result[i] = value;
        }

        return result;
    }
}