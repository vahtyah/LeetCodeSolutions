namespace LeetCodeSolutions.BitManipulation;

/*
 * 0036. Valid Sudoku
 * Difficulty: Medium
 * Submission Time: 2025-02-13 06:01:48
 * Created by vahtyah on 2025-02-13 06:02:05
*/
 
public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        var seenRows = new int[9];
        var seenCols = new int[9];
        var seenBoxes = new int[9];
        
        for (int rowIndex = 0; rowIndex < 9; rowIndex++)
        {
            for (int columnIndex = 0; columnIndex < 9; columnIndex++)
            {
                if (board[rowIndex][columnIndex] == '.')
                {
                    continue;
                }
                
                int number = board[rowIndex][columnIndex] - '0';
                var bitmask = 1 << number;
                
                var boxIndex = rowIndex / 3 * 3 + columnIndex / 3;
                
                if((seenRows[rowIndex] & bitmask) != 0  
                   || (seenCols[columnIndex] & bitmask) != 0
                   || (seenBoxes[boxIndex] & bitmask) != 0)
                {
                    return false;
                }
                
                seenRows[rowIndex] |= bitmask;
                seenCols[columnIndex] |= bitmask;
                seenBoxes[boxIndex] |= bitmask;
            }
        }
        
        
        return true;
    }
}