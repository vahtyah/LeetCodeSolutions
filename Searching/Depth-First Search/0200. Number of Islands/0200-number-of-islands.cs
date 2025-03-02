namespace LeetCodeSolutions.Searching/Depth-FirstSearch;

/*
 * 0200. Number of Islands
 * Difficulty: Medium
 * Submission Time: 2025-03-02 05:48:42
 * Created by vahtyah on 2025-03-02 05:49:04
*/
 
public class Solution {
    public int NumIslands(char[][] grid) {
        if (grid == null || grid.Length == 0) return 0;
        
        int count = 0;
        int rows = grid.Length;
        int cols = grid[0].Length;
        
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (grid[i][j] == '1') {
                    count++;
                    DFS(grid, i, j);
                }
            }
        }
        return count;
    }
    
    private void DFS(char[][] grid, int i, int j) {
        if (i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length || grid[i][j] != '1')
            return;
        grid[i][j] = '0';
        DFS(grid, i + 1, j);
        DFS(grid, i - 1, j);
        DFS(grid, i, j + 1);
        DFS(grid, i, j - 1);
    }
}