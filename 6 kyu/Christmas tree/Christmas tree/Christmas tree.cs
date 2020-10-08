using System.Text;
using System;

public class ChristmasTreeGenerator
{
    public static string ChristmasTree(int height)
    {
        char star = '*';
        char field = ' ';
        StringBuilder tree = new StringBuilder();
        if (height == 0)
        {
            return "";
        }
        else if (height == 1)
        {
            return "*";
        }
        else
        {
            for (int i = 0; i < height; i++)
            {
                for (int o = height - 1; o > i; o--)
                {
                    tree.Append(field);
                }
                for (int j = 0; j < (i + 1) + i; j++)
                {

                    tree.Append(star);
                }
                for (int o = height - 1; o > i; o--)
                {
                    tree.Append(field);
                }
                if (i < height - 1)
                    tree.Append("\n");
            }
            return tree.ToString();
        }
    }
}