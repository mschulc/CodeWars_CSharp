using System;
using System.Text;
using System.Collections.Generic;

public class CodeWars
{
    public static string Binar(string text)
    {
        StringBuilder text1 = new StringBuilder();

        int[] tab = new int[] { 128, 64, 32, 16, 8, 4, 2, 1 };

        for (int j = 0; j < text.Length; j++)
        {
            int liczba = (int)text[j];
            int x = liczba;

            for (int i = 0; i < tab.Length; i++)
            {
                if (x >= tab[i])
                {
                    x -= tab[i];
                    text1.Append("1");
                }
                else
                {
                    text1.Append("0");
                }
            }
        }
        return text1.ToString();
    }
    public static string Unbinar(string bits)
    {
        int[] tab = new int[] { 128, 64, 32, 16, 8, 4, 2, 1 };
        List<string> list = new List<string>();
        List<int> results = new List<int>();
        StringBuilder text = new StringBuilder();

        for (int i = 0; i < bits.ToString().Length; i++)
        {
            string binar = "";
            for (int j = 0 + i; j <= 7 + i; j++)
            {
                binar += bits.ToString()[j].ToString();
            }
            i += 7;
            list.Add(binar);
        }
        for (int j = 0; j < list.Count; j++)
        {
            int value = 0;
            for (int i = 0; i < list[j].ToString().Length; i++)
            {
                if (list[j].ToString()[i] == '1')
                {
                    value += tab[i];
                }
            }
            results.Add(value);
        }
        for (int i = 0; i < results.Count; i++)
        {
            text.Append((char)results[i]);
        }
        return text.ToString();
    }

    public static string encode(string text)
    {
        StringBuilder text1 = new StringBuilder();
        string bits = Binar(text);
        for (int i = 0; i < bits.Length; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (bits[i] == '0')
                {
                    text1.Append("0");
                }
                else if (bits[i] == '1')
                {
                    text1.Append("1");
                }
            }
        }
        return text1.ToString();
    }
    public static string decode(string bits)
    {
        List<string> list = new List<string>();
        StringBuilder text = new StringBuilder();
        int j = 0;
        do
        {
            for (int i = 0; i < 3; i++)
            {
                text.Append(bits[j]);
                j++;
            }
            list.Add(text.ToString());
            text.Clear();
        } while (j != bits.Length);
        text.Clear();
        for (int i = 0; i < list.Count; i++)
        {
            int a = 0;
            int b = 0;
            for (int k = 0; k < list[i].Length; k++)
            {
                if (list[i][k] == '0')
                {
                    a++;
                }
                else if (list[i][k] == '1')
                {
                    b++;
                }
            }
            if (a > b)
            {
                text.Append("0");
            }
            else if (b > a)
            {
                text.Append("1");
            }
        }
        return Unbinar(text.ToString());
    }
}