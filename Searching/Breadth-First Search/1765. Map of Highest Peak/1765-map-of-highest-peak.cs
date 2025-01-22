namespace LeetCodeSolutions.Searching/Breadth-FirstSearch;

/*
 * 1765. Map of Highest Peak
 * Difficulty: Medium
 * Created by vahtyah on 2025-01-22 10:29:34
 */
 
public class Solution {
    public int[][] HighestPeak(int[][] isWater) {
        int m = isWater.Length;
        int n = isWater[0].Length;
        
        Queue<(int x, int y)> queue = new Queue<(int x, int y)>();
        
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (isWater[i][j] == 1) {
                    queue.Enqueue((i, j));
                    isWater[i][j] = 0;
                } else {
                    isWater[i][j] = -1;
                }
            }
        }
        
        int[] dx = { -1, 0, 1, 0 };
        int[] dy = { 0, 1, 0, -1 };
        
        while (queue.Count > 0) {
            var (x, y) = queue.Dequeue();
            
            for (int i = 0; i < 4; i++) {
                int newX = x + dx[i];
                int newY = y + dy[i];
                
                if (newX < 0 || newX >= m || newY < 0 || newY >= n || isWater[newX][newY] != -1) {
                    continue;
                }
                
                isWater[newX][newY] = isWater[x][y] + 1;
                queue.Enqueue((newX, newY));
            }
        }
        
        return isWater;
    }
}