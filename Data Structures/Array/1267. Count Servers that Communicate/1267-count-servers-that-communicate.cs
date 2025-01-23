namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 1267. Count Servers that Communicate
 * Difficulty: Medium
 * Created by vahtyah on 2025-01-23 10:10:08
 */
 
public class Solution {
    public int CountServers(int[][] grid) {
        int m = grid.Length;
        int n = grid[0].Length;
        
        Span<int> rows = stackalloc int[m];
        Span<int> cols = stackalloc int[n];
        
        int totalServers = 0;
        
        for (int i = 0; i < m; ++i) {
            for (int j = 0; j < n; ++j) {
                if (grid[i][j] == 1) {
                    ++rows[i];
                    ++cols[j];
                    ++totalServers;
                }
            }
        }
        
        int isolatedServers = 0;
        for (int i = 0; i < m; ++i) {
            for (int j = 0; j < n; ++j) {
                if (grid[i][j] == 1 && rows[i] == 1 && cols[j] == 1) {
                    ++isolatedServers;
                }
            }
        }
        
        return totalServers - isolatedServers;
    }
}