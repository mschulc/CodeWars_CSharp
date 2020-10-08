public class ProdFib
{
    public static ulong Fibonnaci(ulong n)
    {
        ulong x = 0;
        ulong y = 1;
        ulong fib = 0;
        if (n <= 1)
        {
            return 1;
        }
        else
        {
            for (ulong i = 2; i < n + 1; i++)
            {
                fib = x + y;
                x = y;
                y = fib;
            }
            return fib;
        }
    }
    public static ulong[] productFib(ulong prod)
    {
        ulong[] tab = new ulong[3];
        ulong count = 0;
        if (prod == 0)
        {
            return null;
        }
        for (ulong i = 0; i < prod; i++)
        {
            count = (ulong)Fibonnaci(i) * (ulong)Fibonnaci(i + 1);
            if (count == prod)
            {
                tab[0] = (ulong)Fibonnaci(i);
                tab[1] = (ulong)Fibonnaci(i + 1);
                tab[2] = 1;
                break;
            }
            else if (count > prod)
            {
                tab[0] = (ulong)Fibonnaci(i);
                tab[1] = (ulong)Fibonnaci(i + 1);
                tab[2] = 0;
                break;
            }
        }
        return tab;
    }
}