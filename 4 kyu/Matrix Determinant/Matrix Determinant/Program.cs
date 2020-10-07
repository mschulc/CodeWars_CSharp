public class Matrix
{
    public static int[][] NewMatrix(int[][] m, int k, int l)
    {
        int n = m.Length;
        int[][] tab = new int[n - 1][];

        for (int i = 0; i < n - 1; i++)
        {
            int u = l;
            tab[i] = new int[n - 1];
            for (int j = 0; j < n - 1; j++)
            {
                if (k == i && u == j)
                {
                    tab[i][j] = m[i + 1][j + 1];
                    u += 1;
                }
                else if (k == i)
                {
                    tab[i][j] = m[i + 1][j];
                }
                else if (j == l)
                {
                    tab[i][j] = m[i][j + 1];
                    k -= 1;
                }
                else
                {
                    tab[i][j] = m[i][j];
                }
            }
            k += 1;
        }
        return tab;
    }
    public static int Determinant(int[][] matrix)
    {
        if (matrix.Length <= 1)
        {
            return matrix[0][0];
        }
        else
        {
            int score = 0;
            int m = 1;
            for (int i = 0; i < matrix.Length; i++)
            {
                score += matrix[0][i] * m * Determinant(NewMatrix(matrix, 0, i));
                m = -m;
            }
            return score;
        }
    }
}
