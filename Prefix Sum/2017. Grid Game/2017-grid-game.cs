public class Solution {
    public long GridGame(int[][] grid) {
        if (grid == null || grid.Length != 2 || grid[0].Length == 0) {
            return 0;
        }

        int n = grid[0].Length;
        
        long topSum = 0;
        long bottomSum = 0;
        
        for (int i = 0; i < n; i++) {
            topSum += grid[0][i];
        }
        
        long result = long.MaxValue;
        long currentTopSum = topSum;
        
        for (int i = 0; i < n; i++) {
            currentTopSum -= grid[0][i]; 
            long maxScore = Math.Max(currentTopSum, bottomSum);
            result = Math.Min(result, maxScore);
            bottomSum += grid[1][i];  
        }
        
        return result;
    }
}