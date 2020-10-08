using System;

public class Kata
{
    public static char AddLetters(char[] letters)
    {
        char[] alphabet = { 'z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y' };
        int count = 0;
        for (int i = 0; i < letters.Length; i++)
        {
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (letters[i] == alphabet[j])
                {
                    count += j;
                    if (count >= alphabet.Length)
                    {
                        count -= alphabet.Length;
                    }
                }
            }
        }
        if (letters is null)
        {
            return alphabet[0];
        }
        else
        {
            return alphabet[count];
        }
    }
}