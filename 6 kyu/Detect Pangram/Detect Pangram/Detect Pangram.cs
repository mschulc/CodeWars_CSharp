using System;

public static class Kata
{
    public static bool IsPangram(string str)
    {
        char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        bool resault = true;
        for (int i = 0; i < alphabet.Length; i++)
        {
            if (str.ToLower().Contains(alphabet[i]) == false)
            {
                resault = false;
                break;
            }
        }
        return resault;
    }
}