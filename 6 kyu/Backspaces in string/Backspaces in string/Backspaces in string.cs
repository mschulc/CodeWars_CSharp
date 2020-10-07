using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Kata
{
    public static string CleanString(string s)
    {
        List<char> list = s.ToList();
        StringBuilder text = new StringBuilder();
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] == '#')
            {
                list.RemoveAt(i);
                if (i != 0)
                {
                    list.RemoveAt(i - 1);
                }
                i = -1;
            }
        }
        foreach (var item in list)
        {
            text.Append(item);
        }
        return text.ToString();
    }
}