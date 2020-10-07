using System;
public class BuyCar
{
    public static int[] nbMonths(int startPriceOld, int startPriceNew, int savingPerMonth, double percentLossByMonth)
    {
        int[] tab = new int[2];
        double oldP = startPriceOld;
        double newP = startPriceNew;
        int save = 0;
        int i = 0;
        double percent = percentLossByMonth;
        while (save + oldP < newP)
        {
            i++;
            if (i % 2 == 0)
            {
                percent += 0.5;
            }
            save += savingPerMonth;
            oldP -= (oldP * percent / 100);
            newP -= (newP * percent / 100);
        }
        tab[0] = i;
        tab[1] = (int)Math.Round(save + oldP - newP);

        return tab;
    }
}
