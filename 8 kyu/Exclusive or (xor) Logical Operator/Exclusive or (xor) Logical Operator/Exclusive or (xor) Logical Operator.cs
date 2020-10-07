public class Kata
{
    public static bool Xor(bool a, bool b)
    {
        if (a == true && b == false)
            return true;
        else if (b == true && a == false)
            return true;
        else
            return false;
    }
}