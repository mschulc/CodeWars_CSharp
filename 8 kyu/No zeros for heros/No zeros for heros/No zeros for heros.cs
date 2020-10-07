using System;
using System.Text;
using System.Collections.Generic;

public class NoBoring
{
    public static int NoBoringZeros(int n)
    {
        StringBuilder text = new StringBuilder();
        text.Append(n);
        List<string> lista = new List<string>();
        for (int i = 0; i < text.ToString().Length; i++)
        {
            lista.Add(text[i].ToString());
        }
        for (int i = lista.Count - 1; i >= 0; i--)
        {
            if (lista[0] == "0")
                lista.Add("0");
            else if (lista[i] == "0")
            {
                lista.RemoveAt(i);
            }
            else if (lista[i] != "0")
                break;
        }
        text.Clear();
        for (int i = 0; i < lista.Count; i++)
        {
            text.Append(lista[i]);
        }
        return int.Parse(text.ToString());
    }
}