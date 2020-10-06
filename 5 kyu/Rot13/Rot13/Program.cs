using System;
using System.Text;
using System.Collections.Generic;
public class Kata
{
    public static string Rot13(string message)
    {
        Dictionary<char, int> torrorosso = new Dictionary<char, int>();
        Dictionary<int, char> alphatauri = new Dictionary<int, char>();
        List<int> upper = new List<int>();
        StringBuilder text = new StringBuilder();
        StringBuilder text1 = new StringBuilder();
        string lower = message.ToLower();
        int j = 1;
        int k = 14;
        torrorosso.Add(' ', 0);
        alphatauri.Add(0, ' ');
        for (char i = 'a'; i <= 'z'; i++)
        {
            torrorosso.Add(i, k);
            alphatauri.Add(j, i);
            k++;
            if (k == 27)
            {
                k = 1;
            }
            j++;
        }
        for (int i = 0; i < lower.Length; i++)
        {
            if (message[i].ToString() == message[i].ToString().ToUpper())
            {
                upper.Add(i);
            }
            if (torrorosso.ContainsKey(lower[i]))
            {
                text.Append(alphatauri.GetValueOrDefault(torrorosso.GetValueOrDefault(lower[i])));
            }
            else
            {
                text.Append(lower[i]);
            }
        }

        for (int i = 0; i < message.Length; i++)
        {
            if (upper.Contains(i))
            {
                text1.Append(text[i].ToString().ToUpper());
            }
            else
            {
                text1.Append(text[i]);
            }
        }

        return text1.ToString();
    }
}