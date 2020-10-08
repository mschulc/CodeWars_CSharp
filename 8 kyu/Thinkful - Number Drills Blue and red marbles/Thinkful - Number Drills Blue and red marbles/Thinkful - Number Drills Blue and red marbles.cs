public static class BlueAndRedMarbles
{
    public static double GuessBlue(uint blueStart, uint redStart, uint bluePulled, uint redPulled)
    {
        double count = ((double)blueStart - (double)bluePulled) / (((double)blueStart - (double)bluePulled) + ((double)redStart - (double)redPulled));
        return count;
    }
}