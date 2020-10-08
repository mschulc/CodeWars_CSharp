public static class Kata
{
    public static string Maskify(string cc)
    {
        string nap = "";
        for (int i = 0; i < cc.Length; i++)
        {
            if (i < cc.Length - 4)
            {
                nap = nap + "#";
            }
            else if (i >= cc.Length - 4)
            {
                nap = nap + cc[i];
            }
        }
        return nap;
    }
}
