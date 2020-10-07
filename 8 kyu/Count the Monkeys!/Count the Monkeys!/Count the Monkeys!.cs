public static class MonkeyCounter
{
    public static int[] MonkeyCount(int n)
    {
        int[] monkey = new int[n];
        for (int i = 0; i < n; i++)
        {
            monkey[i] = i + 1;
        }
        return monkey;
    }
}
