namespace LeetCodeSolutions.Backtracking;

/*
 * 0051. N-Queens
 * Difficulty: Hard
 * Submission Time: 2025-02-07 19:46:21
 * Created by vahtyah on 2025-02-07 19:46:41
*/
 
public class Solution {
    public IList<IList<string>> SolveNQueens(int n) {
        var result = new List<IList<string>>();
        BacktrackBitwise(n, 0, 0, 0, 0, new int[n], result);
        return result;
    }

    private void BacktrackBitwise(int n, int row, int columns, int diagonals, int antiDiagonals, int[] queens, List<IList<string>> result) {
        if (row == n) {
            result.Add(GenerateBoard(queens));
            return;
        }

        // Get all valid positions for current row
        int validPositions = ((1 << n) - 1) & 
                           ~(columns | diagonals | antiDiagonals);

        while (validPositions != 0) {
            // Get rightmost valid position
            int position = validPositions & -validPositions;
            // Clear the rightmost 1-bit
            validPositions &= (validPositions - 1);
            
            // Get column index from position
            int col = CountTrailingZeros(position);
            queens[row] = col;

            // Recursively try next row
            BacktrackBitwise(
                n,
                row + 1,
                columns | position,
                (diagonals | position) << 1,
                (antiDiagonals | position) >> 1,
                queens,
                result
            );
        }
    }

    private List<string> GenerateBoard(int[] queens) {
        var board = new List<string>(queens.Length);
        var row = new char[queens.Length];
        Array.Fill(row, '.');
        
        for (int i = 0; i < queens.Length; i++) {
            row[queens[i]] = 'Q';
            board.Add(new string(row));
            row[queens[i]] = '.';
        }
        
        return board;
    }

    private int CountTrailingZeros(int n) {
        if (n == 0) return 32;
        int count = 0;
        while ((n & 1) == 0) {
            count++;
            n >>= 1;
        }
        return count;
    }
}

public class Solution {
    public IList<IList<string>> SolveNQueens(int n) {
        var chessboard = new List<IList<string>>();
        var queens = new int[n];
        Backtracking(queens, 0, chessboard);
        return chessboard;
    }

    public void Backtracking(int[] queens, int row, List<IList<string>> chessboard){
        if(row == queens.Length){
            chessboard.Add(GetBoard(queens));
            return;
        }
        for(var col = 0; col < queens.Length; col++){
            if(IsValidPosition(queens, row, col)){
                queens[row] = col;
                Backtracking(queens, row + 1, chessboard);
            }
        }
    }

    public bool IsValidPosition(int[] queens, int row, int col){
        for(var prevRow = 0; prevRow < row; prevRow++){
            var prevCol = queens[prevRow];
            if(prevCol == col) return false;
            if(Math.Abs(prevCol - col) == row - prevRow) return false;
        }
        return true;
    }

    public List<string> GetBoard(int[] queens){
        var board = new List<string>(queens.Length);
        var row = new char[queens.Length];
        Array.Fill(row, '.');
        for (var i = 0; i < queens.Length; i++)
        {
            row[queens[i]] = 'Q';
            board.Add(new string(row));
            row[queens[i]] = '.';
        }

        return board;
    }
}