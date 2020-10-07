using System;
using System.Collections.Generic;

public class PyramidSlideDown
{
    public static int LongestSlideDown(int[][] pyramid)
    {
        Dictionary<string, int> way = new Dictionary<string, int>();
        return Pyramid(pyramid, 0, 0, way);
    }

    private static int Pyramid(int[][] pyramid, int x, int y, Dictionary<string, int> way)
    {
        if (x >= pyramid.Length || y >= pyramid[x].Length)
        {
            return 0;
        }

        if (x == pyramid.Length - 1)
        {
            return pyramid[x][y];
        }

        string key = $"{x}:{y}";
        if (way.ContainsKey(key))
        {
            return way[key];
        }

        int max = 0;
        for (int i = 0; i < 2; i++)
        {
            int step = Pyramid(pyramid, x + 1, y + i, way);
            if (step > max)
            {
                max = step;
            }
        }

        way[key] = pyramid[x][y] + max;
        return way[key];
    }
}