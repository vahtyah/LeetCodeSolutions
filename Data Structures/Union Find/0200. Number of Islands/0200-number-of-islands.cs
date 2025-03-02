namespace LeetCodeSolutions.DataStructures/UnionFind;

/*
 * 0200. Number of Islands
 * Difficulty: Medium
 * Submission Time: 2025-03-02 05:48:42
 * Created by vahtyah on 2025-03-02 05:51:44
*/
 
public class Solution {
    private int[] parent;
    private int count;
    public int NumIslands(char[][] grid) {
        if (grid == null || grid.Length == 0) return 0;
        
        int rows = grid.Length;
        int cols = grid[0].Length;
        UnionFind(grid);
        
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (grid[i][j] == '1') {
                    grid[i][j] = '0';
                    if (i + 1 < rows && grid[i + 1][j] == '1')
                        Union(i * cols + j, (i + 1) * cols + j);
                    if (i - 1 >= 0 && grid[i - 1][j] == '1')
                        Union(i * cols + j, (i - 1) * cols + j);
                    if (j + 1 < cols && grid[i][j + 1] == '1')
                        Union(i * cols + j, i * cols + (j + 1));
                    if (j - 1 >= 0 && grid[i][j - 1] == '1')
                        Union(i * cols + j, i * cols + (j - 1));
                }
            }
        }
        
        return count;
    }
    
    public void UnionFind(char[][] grid) {
        int rows = grid.Length;
        int cols = grid[0].Length;
        parent = new int[rows * cols];
        count = 0;
        
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (grid[i][j] == '1') {
                    parent[i * cols + j] = i * cols + j;
                    count++;
                }
            }
        }
    }
    
    public int Find(int x) {
        if (parent[x] != x)
            parent[x] = Find(parent[x]); // Path compression
        return parent[x];
    }
    
    public void Union(int x, int y) {
        int rootX = Find(x);
        int rootY = Find(y);
        if (rootX != rootY) {
            parent[rootX] = rootY;
            count--;
        }
    }
}