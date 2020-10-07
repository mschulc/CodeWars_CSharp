public class Kata
{
    public static string Shark(
      int pontoonDistance,
      int sharkDistance,
      int yourSpeed,
      int sharkSpeed,
      bool dolphin)
    {
        double me = (double)pontoonDistance / (double)yourSpeed;
        double shark = 0;

        if (dolphin == true)
        {
            shark = (double)sharkDistance / (double)(sharkSpeed / 2);
        }
        else if (dolphin == false)
        {
            shark = (double)sharkDistance / (double)sharkSpeed;
        }
        if (sharkDistance == 0)
            return "Shark Bait!";
        else if (pontoonDistance == 0)
            return "Alive!";
        else if (shark < me)
        {
            return "Shark Bait!";
        }
        else
        {
            return "Alive!";
        }
    }
}