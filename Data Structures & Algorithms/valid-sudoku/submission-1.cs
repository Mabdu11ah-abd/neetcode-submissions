public class Solution {
    public bool IsValidSudoku(char[][] board) {

        HashSet<char> set = new();
        HashSet<char> colSet = new();
        HashSet<char> boxSet = new();
        for(int i = 0;  i< board.Length ; i++){
            for(int j = 0; j < board[i].Length; j++)
            {
                Console.WriteLine("This is my line " + board[i][j]);
                Console.WriteLine("This is my line " + board[j][i]);
                // check within the limits of box as well.
                if(char.IsDigit(board[i][j]))
                {
                    bool notduplicate = set.Add(board[i][j]);

                    if(!notduplicate)
                    {
                        return false;
                    }
                }

                if(char.IsDigit(board[j][i]))
                {
                    bool notduplicate = colSet.Add(board[j][i]);

                    if(!notduplicate)
                    {
                        Console.WriteLine("returning false" + board[j][i]);
                        return false;
                    }
                }

            }

            set.Clear();
            colSet.Clear();
        }


        for (int boxRow = 0; boxRow < 9; boxRow += 3)
        {
            for (int boxCol = 0; boxCol < 9; boxCol += 3)
            {
                boxSet.Clear();

                for (int r = 0; r < 3; r++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        char cell = board[boxRow + r][boxCol + c];

                        if (cell == '.')
                            continue;

                        if (!boxSet.Add(cell))
                            return false;
                    }
                }
            }
        }
        return true;
    }
}
