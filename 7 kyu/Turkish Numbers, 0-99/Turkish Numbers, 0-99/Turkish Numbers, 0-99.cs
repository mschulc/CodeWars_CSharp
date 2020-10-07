public class Kata
{
    public static string GetTurkishNumber(int num)
    {
        string[] tab1 = { "sıfır", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
        string[] tab2 = { "x", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };

        string a = num.ToString();

        if (a.Length > 1 && int.Parse(a[1].ToString()) == 0)
        {
            return tab2[int.Parse(a[0].ToString())];
        }
        else if (a.Length > 1)
        {
            return tab2[int.Parse(a[0].ToString())] + " " + tab1[int.Parse(a[1].ToString())];
        }
        else
        {
            return tab1[int.Parse(a[0].ToString())];
        }
    }
}