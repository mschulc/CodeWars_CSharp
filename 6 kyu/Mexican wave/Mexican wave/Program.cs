using System;
using System.Text;
using System.Collections.Generic;

namespace CodeWars
{
    public class Kata
    {
        public List<string> wave(string str)
        {
            List<string> list = new List<string>();
            StringBuilder text = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < str.Length; j++)
                {
                    if (j == i)
                        text.Append(str[j].ToString().ToUpper());
                    else
                        text.Append(str[j].ToString().ToLower());
                }
                list.Add(text.ToString());
                text.Clear();
            }
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (list[i] == str.ToLower())
                {
                    list.RemoveAt(i);
                }
            }
            return list;
        }
    }
}