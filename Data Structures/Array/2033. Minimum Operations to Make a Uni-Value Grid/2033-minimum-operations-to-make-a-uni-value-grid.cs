namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 2033. Minimum Operations to Make a Uni-Value Grid
 * Difficulty: Medium
 * Submission Time: 2025-03-26 05:48:28
 * Created by vahtyah on 2025-03-26 05:49:32
*/
 
public class Solution {
    public int MinOperations(int[][] grid, int x) {
        int m = grid.Length;
        int n = grid[0].Length;
        
        int remainder = grid[0][0] % x;
        
        int[] values = new int[m * n];
        int idx = 0;
        
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (grid[i][j] % x != remainder) {
                    return -1; 
                }
                values[idx++] = grid[i][j];
            }
        }
        
        Array.Sort(values);
        
        int median = values[m * n / 2];
        
        int operations = 0;
        ReadOnlySpan<int> span = values.AsSpan();
        foreach (int val in span) {
            operations += Math.Abs(val - median) / x;
        }
        
        return operations;
    }
}