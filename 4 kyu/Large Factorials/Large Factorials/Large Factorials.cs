using System;
using System.Numerics;
using System.Text;
using System.Collections;
using System.Collections.Generic;

public class Kata
{
    public static string Factorial(int n)
    {
        string factorial = "1";
        for (int g = 1; g <= n; g++)
        {
            string liczba = factorial;
            string mnożnik = g.ToString();
            StringBuilder suma = new StringBuilder();
            StringBuilder wynikK = new StringBuilder();
            List<string> wynikL = new List<string>();
            string pomoc = "";
            List<string> listaK = new List<string>();
            for (int k = mnożnik.Length - 1; k >= 0; k--)
            {
                string malyWynik = "";
                StringBuilder wynik = new StringBuilder();
                ArrayList lista = new ArrayList();
                for (int i = liczba.Length - 1; i >= 0; i--)
                {
                    int y = 0;
                    int x = 0;
                    x = (int.Parse(liczba[i].ToString()) * int.Parse(mnożnik[k].ToString()));
                    if (malyWynik.Length > 1)
                    {
                        y = x + int.Parse(malyWynik[0].ToString());
                    }
                    else
                    {
                        y = x;
                    }
                    malyWynik = y.ToString();
                    if (i == 0)
                    {
                        if (y < 10)
                        {
                            lista.Add(malyWynik[0]);
                        }
                        else
                        {
                            lista.Add(malyWynik[1]);
                            lista.Add(malyWynik[0]);
                        }
                    }
                    else if (malyWynik.Length > 1)
                    {
                        lista.Add(malyWynik[1]);
                    }
                    else
                    {
                        lista.Add(y);
                    }
                }
                for (int i = lista.Count - 1; i >= 0; i--)
                {
                    wynik.Append(lista[i]);
                }
                for (int i = k; i < mnożnik.Length - 1; i++)
                {
                    wynik.Append("0");
                }
                listaK.Add(wynik.ToString());
            }

            string tymczasowy = "";
            for (int i = listaK.Count - 1; i >= 0; i--)
            {
                StringBuilder cos = new StringBuilder();
                if (listaK[listaK.Count - 1].Length != listaK[i].Length)
                {
                    tymczasowy = listaK[i];
                    for (int j = 0; j < listaK[listaK.Count - 1].Length - listaK[i].Length; j++)
                    {
                        cos.Append("0");
                    }
                    cos.Append(tymczasowy);
                    listaK[i] = cos.ToString();
                }
            }

            for (int i = listaK[listaK.Count - 1].Length - 1; i >= 0; i--)
            {
                int licz = 0;
                int licz1 = 0;
                for (int j = listaK.Count - 1; j >= 0; j--)
                {
                    licz += int.Parse(listaK[j][i].ToString());
                }
                if (pomoc.Length > 1)
                {
                    licz1 = licz + int.Parse(pomoc[0].ToString());
                }
                else
                {
                    licz1 = licz;
                }
                pomoc = licz1.ToString();

                if (i != 0)
                {
                    wynikL.Add(pomoc[pomoc.Length - 1].ToString());
                }
                else
                {
                    wynikL.Add(pomoc);
                }
            }
            for (int i = wynikL.Count - 1; i >= 0; i--)
            {
                suma.Append(wynikL[i]);
            }
            factorial = suma.ToString();
        }
        return factorial;

    }
}