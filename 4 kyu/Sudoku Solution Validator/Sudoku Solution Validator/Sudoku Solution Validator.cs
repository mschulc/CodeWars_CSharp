public class Sudoku
{
    public static bool ValidateSolution(int[][] board)
    {
        bool wynik = true;
        for (int i = 0; i < board.Length; i++)
        {
            int count1 = 0;
            int count2 = 0;

            for (int j = 0; j < board[i].Length; j++)
            {
                count1 = count1 + int.Parse(board[i][j].ToString());
                count2 = count2 + int.Parse(board[j][i].ToString());
            }
            if (count1 != 45 || count2 != 45)
            {
                wynik = false;
                break;
            }
        }
        int count3 = 0;
        int count4 = 0;
        int count5 = 0;
        int count6 = 0;
        int count7 = 0;
        int count8 = 0;
        int count9 = 0;
        int count10 = 0;
        int count11 = 0;
        for (int i = 0; i <= 2; i++)
        {
            for (int j = 0; j <= 2; j++)
            {
                count3 = count3 + int.Parse(board[j][i].ToString());
            }
        }
        for (int i = 0; i <= 2; i++)
        {
            for (int j = 3; j <= 5; j++)
            {
                count4 = count4 + int.Parse(board[j][i].ToString());
            }
        }
        for (int i = 0; i <= 2; i++)
        {
            for (int j = 6; j <= 8; j++)
            {
                count5 = count5 + int.Parse(board[j][i].ToString());
            }
        }
        for (int i = 3; i <= 5; i++)
        {
            for (int j = 3; j <= 5; j++)
            {
                count6 = count6 + int.Parse(board[j][i].ToString());
            }
        }
        for (int i = 3; i <= 5; i++)
        {
            for (int j = 0; j <= 2; j++)
            {
                count7 = count7 + int.Parse(board[j][i].ToString());
            }
        }
        for (int i = 3; i <= 5; i++)
        {
            for (int j = 6; j <= 8; j++)
            {
                count8 = count8 + int.Parse(board[j][i].ToString());
            }
        }
        for (int i = 6; i <= 8; i++)
        {
            for (int j = 3; j <= 5; j++)
            {
                count9 = count9 + int.Parse(board[j][i].ToString());
            }
        }
        for (int i = 6; i <= 8; i++)
        {
            for (int j = 0; j <= 2; j++)
            {
                count10 = count10 + int.Parse(board[j][i].ToString());
            }
        }
        for (int i = 6; i <= 8; i++)
        {
            for (int j = 6; j <= 8; j++)
            {
                count11 = count11 + int.Parse(board[j][i].ToString());
            }
        }
        if (count3 != 45 || count4 != 45 || count5 != 45 || count6 != 45 || count7 != 45 || count8 != 45 || count9 != 45 || count10 != 45 || count11 != 45)
        {
            wynik = false;
        }
        return wynik;
    }
}
