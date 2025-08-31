namespace LeetCodeSolutions.Recursion/Backtracking;

/*
 * 0037. Sudoku Solver
 * Difficulty: Hard
 * Submission Time: 2025-08-31 08:18:04
 * Created by vahtyah on 2025-08-31 08:18:34
*/
 
public class Solution {
    public void SolveSudoku(char[][] board) {
        var seenRows = new int[9];
        var seenCols = new int[9];
        var seenBoxes = new int[9];
        
        for(int row = 0; row < 9; row++){
            for(int col = 0; col < 9; col++){
                if(board[row][col] == '.') continue;
                var digit = board[row][col] - '0' - 1;
                var bitmask = 1 << digit;
                seenRows[row] |= bitmask;
                seenCols[col] |= bitmask;
                seenBoxes[GetBox(row, col)] |= bitmask;
            }
        }

        Backtrack(board, seenRows, seenCols, seenBoxes, 0, 0);
    }

    private bool Backtrack(char[][] board, int[] seenRows, int[] seenCols, int[] seenBoxes, int row, int col){
        if(col > 8){
            row++;
            col = 0;
        }
        if(row > 8) return true;
        
        if(board[row][col] != '.'){
            return Backtrack(board, seenRows, seenCols, seenBoxes, row, col + 1);
        }

        for(int i = 0; i < 9; i++){
            var bitmask = 1 << i;
            var boxIndex = GetBox(row, col);
            
            if((seenRows[row] & bitmask) != 0
            || (seenCols[col] & bitmask) != 0
            || (seenBoxes[boxIndex] & bitmask) != 0
            ) continue;

            seenRows[row] |= bitmask;
            seenCols[col] |= bitmask;
            seenBoxes[boxIndex] |= bitmask;

            board[row][col] = (char)(i + 1 + '0');

            if(Backtrack(board, seenRows, seenCols, seenBoxes, row, col + 1))
                return true;

            board[row][col] = '.';
            seenRows[row] ^= bitmask;
            seenCols[col] ^= bitmask;
            seenBoxes[boxIndex] ^= bitmask;
        }
        
        return false;
    }

    private int GetBox(int row, int col){
        return row / 3 * 3 + col / 3;
    }
}