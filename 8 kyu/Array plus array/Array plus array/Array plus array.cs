public static class Kata
{
    public static int ArrayPlusArray(int[] arr1, int[] arr2)
    {
        int score = 0;
        for (int i = 0; i < arr1.Length; i++)
        {
            score += arr1[i];
        }
        for (int i = 0; i < arr2.Length; i++)
        {
            score += arr2[i];
        }
        return score;
    }
}