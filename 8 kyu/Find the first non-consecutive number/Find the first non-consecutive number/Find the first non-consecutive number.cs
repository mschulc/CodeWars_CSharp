using System.Collections.Generic;

public class Kata
{
    public static object FirstNonConsecutive(int[] arr)
    {
        List<int> lista = new List<int>();
        if (arr.Length > 0)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i >= arr.Length - 1)
                    return null;
                else if (arr[i] != arr[i + 1] - 1)
                {
                    lista.Add(arr[i + 1]);
                    break;
                }
            }
            if (lista.Count != 0)
                return lista[0];
            else
                return null;
        }
        else
        {
            return null;
        }
    }
}