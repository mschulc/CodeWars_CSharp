using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static List<string> CartesianP(List<string> tab1, string[] tab2)
    {
        List<string> list = new List<string>();

        for (int i = 0; i < tab1.Count; i++)
        {
            for (int j = 0; j < tab2.Length; j++)
            {
                list.Add(tab1[i].ToString() + tab2[j].ToString());
            }
        }
        return list;
    }
    public static List<string> GetPINs(string observed)
    {
        string[][] tab =
        {
                new string[]{ "8", "0" },                   // 0
                new string[]{ "1", "2", "4" },              // 1
                new string[]{ "1", "2", "3", "5" },         // 2
                new string[]{ "2", "3", "6" },              // 3
                new string[]{ "1", "4", "5", "7" },         // 4
                new string[]{ "2", "4", "5", "6", "8" },    // 5
                new string[]{ "3", "5", "6", "9" },         // 6
                new string[]{ "4", "7", "8" },              // 7
                new string[]{ "5", "7", "8", "9", "0" },    // 8
                new string[]{ "6", "8", "9" }               // 9
            };
        List<string> result = tab[int.Parse(observed[0].ToString())].ToList();

        for (int i = 1; i < observed.Length; i++)
        {
            result = CartesianP(result, tab[int.Parse(observed[i].ToString())]);
        }

        return result;
    }
}