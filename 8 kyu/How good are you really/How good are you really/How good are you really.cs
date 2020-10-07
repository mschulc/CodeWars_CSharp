public class Kata
{
    public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
    {
        int score = 0;
        for (int i = 0; i < ClassPoints.Length; i++)
        {
            score += ClassPoints[i];
        }
        double avarage = score / ClassPoints.Length;
        if (avarage > YourPoints)
            return false;
        else
            return true;
    }
}
