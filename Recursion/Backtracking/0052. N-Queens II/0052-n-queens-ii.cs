namespace LeetCodeSolutions.Recursion/Backtracking;

/*
 * 0052. N-Queens II
 * Difficulty: Hard
 * Submission Time: 2025-06-06 20:39:18
 * Created by vahtyah on 2025-06-06 21:26:23
*/
 
public class Solution {
    public int TotalNQueens(int n) {
        return SolveNQueens(0, 0, 0, 0, n);
    }
    
    private int SolveNQueens(int row, int cols, int diag1, int diag2, int n) {
        if (row == n) return 1;
        
        int count = 0;
        int availablePositions = ((1 << n) - 1) & ~(cols | diag1 | diag2);
        
        while (availablePositions != 0) {
            int position = availablePositions & -availablePositions;
            availablePositions ^= position;
            
            count += SolveNQueens(
                row + 1,
                cols | position,
                (diag1 | position) << 1,
                (diag2 | position) >> 1,
                n
            );
        }
        
        return count;
    }
}