using System.Collections.Generic;
using System.Linq
    ;
public class NoOddities
{
    public static int[] NoOdds(int[] values)
    {
        List<int> list = new List<int>();
        for (int i = 0; i < values.Length; i++)
        {
            if (values[i] % 2 == 0)
                list.Add(values[i]);
        }
        return list.ToArray();
    }
}