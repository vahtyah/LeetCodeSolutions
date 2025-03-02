namespace LeetCodeSolutions.Searching/Breadth-FirstSearch;

/*
 * 0200. Number of Islands
 * Difficulty: Medium
 * Submission Time: 2025-03-02 05:48:42
 * Created by vahtyah on 2025-03-02 05:55:06
*/
 
public class Solution {
    public int NumIslands(char[][] grid) {
        if (grid == null || grid.Length == 0) return 0;
        
        int rows = grid.Length;
        int cols = grid[0].Length;
        int islands = 0;
        
        int[] dx = { 1, -1, 0, 0 };
        int[] dy = { 0, 0, 1, -1 };
        
        Queue<(int, int)> queue = new Queue<(int, int)>();
        
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (grid[i][j] == '1') {
                    islands++; 
                    grid[i][j] = '0'; 
                    queue.Enqueue((i, j));
                    
                    while (queue.Count > 0) {
                        var (currentX, currentY) = queue.Dequeue();
                        
                        for (int dir = 0; dir < 4; dir++) {
                            int nextX = currentX + dx[dir];
                            int nextY = currentY + dy[dir];
                            
                            if (IsValid(nextX, nextY, rows, cols) && 
                                grid[nextX][nextY] == '1') {
                                grid[nextX][nextY] = '0'; 
                                queue.Enqueue((nextX, nextY));
                            }
                        }
                    }
                }
            }
        }
        
        return islands;
    }
    
    private bool IsValid(int x, int y, int rows, int cols) {
        return x >= 0 && x < rows && y >= 0 && y < cols;
    }
}