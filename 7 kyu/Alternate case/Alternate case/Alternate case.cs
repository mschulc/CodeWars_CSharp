using System;
using System.Text;

namespace Solution
{
    public static class Program
    {
        public static string alternateCase(string s)
        {
            StringBuilder text = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].ToString() == s[i].ToString().ToUpper())
                {
                    text.Append(s[i].ToString().ToLower());
                }
                else
                    text.Append(s[i].ToString().ToUpper());
            }

            return text.ToString();
        }
    }
}
