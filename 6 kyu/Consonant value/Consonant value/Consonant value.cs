using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int Solve(string s)
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        List<int> list = new List<int>();
        int count = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
            {
                count = 0;
            }
            else
            {
                count = count + (alphabet.IndexOf(s[i]) + 1);
                list.Add(count);
            }
        }
        if (s is null)
            return 0;
        else
            return list.Max();
    }
}
