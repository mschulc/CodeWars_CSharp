using System;

public static class Kata
{
    public static string BinaryToString(string binary)
    {
        string text = "";

        int j = binary.Length - 1;
        for (int k = 0; k < (binary.Length / 8); k++)
        {

            int l = j;
            int wynik = 0;
            int licznik = 1;

            for (int i = 0; i < 8; i++)
            {
                if (binary[l] == '1')
                {
                    wynik = wynik + licznik;
                }
                l--;
                licznik = licznik * 2;
            }
            j = j - 8;
            text = text + (char)wynik;
        }
        string text2 = "";
        for (int i = text.Length - 1; i >= 0; i--)
        {
            text2 = text2 + text[i].ToString();
        }
        return text2;
    }
}