using System;
using System.Collections.Generic;
using System.Text;

public class Kata
{
    public static long SuperSize(long num)
    {
        StringBuilder score = new StringBuilder();
        List<string> list = new List<string>();
        string text = num.ToString();
        for (int i = 0; i < text.Length; i++)
        {
            list.Add(text[i].ToString());
        }
        list.Sort();
        list.Reverse();
        for (int i = 0; i < list.Count; i++)
        {
            score.Append(list[i]);
        }
        return long.Parse(score.ToString());
    }
}