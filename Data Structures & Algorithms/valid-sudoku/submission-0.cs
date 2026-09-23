public class Solution {
    public bool IsValidSudoku(char[][] board) {
        List<HashSet<char>> rows = new List<HashSet<char>>();
        List<HashSet<char>> colms = new List<HashSet<char>>();
        List<HashSet<char>> box = new List<HashSet<char>>();
        for (int i = 0; i < 9; i++)
{
    rows.Add(new HashSet<char>());
    colms.Add(new HashSet<char>());
    box.Add(new HashSet<char>());
}
        for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
            {
                char c = board[i][j];
                if (c == '.')
                continue;
    if (rows[i].Contains(c) || colms[j].Contains(c) || box[(i / 3) * 3 + (j / 3)].Contains(c))
            {
            return false;
            }
            else
            {
            rows[i].Add(c);
            colms[j].Add(c);
            box[(i / 3) * 3 + (j / 3)].Add(c);
            }
    }
}

return true;
        
    }
}