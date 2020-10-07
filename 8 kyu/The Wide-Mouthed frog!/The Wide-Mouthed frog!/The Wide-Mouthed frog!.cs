public class Kata
{
    public static string MouthSize(string animal)
    {
        if (animal.ToLower() != "alligator")
            return "wide";
        else
            return "small";
    }
}