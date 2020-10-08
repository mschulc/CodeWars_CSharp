using System;
using System.Text;
using System.Collections.Generic;

class UnaryMessage
{
    public static string Send(string text)
    {
        StringBuilder text1 = new StringBuilder();

        int[] tab = new int[] { 64, 32, 16, 8, 4, 2, 1 };

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
        StringBuilder code = new StringBuilder();

        for (int i = 0; i < text1.Length; i++)
        {
            if (text1[i] == '1')
            {
                code.Append("0 ");
                for (int j = i; j < text1.Length; j++)
                {
                    if (text1[j] == '1')
                    {
                        code.Append("0");
                        i = j;
                    }
                    else
                    {
                        code.Append(" ");
                        break;
                    }
                }
            }
            else if (text1[i] == '0')
            {
                code.Append("00 ");
                for (int k = i; k < text1.Length; k++)
                {
                    if (text1[k] == '0')
                    {
                        code.Append("0");
                        i = k;
                    }
                    else
                    {
                        code.Append(" ");
                        break;
                    }
                }
            }
        }
        return code.ToString();
    }

    public static string Receive(string text)
    {
        StringBuilder code = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            if (i >= text.Length - 1)
            {
                break;
            }
            else if (text[i] == '0' && text[i + 1] == ' ')
            {
                for (int j = i + 2; j < text.Length; j++)
                {
                    if (text[j] == '0')
                    {

                        code.Append("1");
                        i = j + 1;
                    }
                    else if (text[j] == ' ' || j == text.Length)
                    {
                        break;
                    }
                }
            }
            else if (text[i] == '0' && text[i + 1] == '0')
            {
                for (int k = i + 3; k < text.Length; k++)
                {
                    if (text[k] == '0')
                    {

                        code.Append("0");
                        i = k + 1;
                    }
                    else if (text[k] == ' ' || k == text.Length)
                    {
                        break;
                    }

                }
            }
        }

        List<string> lista = new List<string>();
        List<int> wyniki = new List<int>();
        StringBuilder textK = new StringBuilder();

        for (int i = 0; i < code.ToString().Length; i++)
        {
            string binar = "";
            for (int j = 0 + i; j <= 6 + i; j++)
            {
                binar += code.ToString()[j].ToString();
            }
            i += 6;
            lista.Add(binar);
        }
        int[] tab = new int[] { 64, 32, 16, 8, 4, 2, 1 };
        for (int j = 0; j < lista.Count; j++)
        {
            int wynik = 0;
            for (int i = 0; i < lista[j].ToString().Length; i++)
            {
                if (lista[j].ToString()[i] == '1')
                {
                    wynik += tab[i];
                }
            }
            wyniki.Add(wynik);
        }
        for (int i = 0; i < wyniki.Count; i++)
        {
            textK.Append((char)wyniki[i]);
        }
        return textK.ToString();
    }
}