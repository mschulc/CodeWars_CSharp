public class Kata
{
    public static int ExpressionsMatter(int a, int b, int c)
    {
        int x = (a + b) * c;
        int y = a + b * c;
        int z = a * b * c;
        int v = a + b + c;
        int r = a * (b + c);
        int k = a * b + c;


        if (x >= y && x >= z && x >= v && x >= r && x >= k)
            return x;
        else if (y >= x && y >= z && y >= v && y >= r && y >= k)
            return y;
        else if (z >= y && z >= x && z >= v && z >= r && z >= k)
            return z;
        else if (v >= y && v >= z && v >= x && v >= r && v >= k)
            return v;
        else if (r >= y && r >= z && r >= v && r >= x && r >= k)
            return r;
        else
            return k;
    }
}