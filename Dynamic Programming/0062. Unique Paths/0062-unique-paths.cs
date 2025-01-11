public class Solution {
    public int UniquePaths(int m, int n) {
        var dp = new int[n,m];

        for(int i = 0; i < n; i++){ //col
            dp[i, 0] = 1;
        }

        for(int i = 1; i < m; i++){ //row
            dp[0, i] = 1;
        }

        for(int i = 1; i < n; i++){
            for(int j = 1; j < m; j++){
                dp[i, j] = (dp[i - 1, j] + dp[i, j - 1]);
            }
        }

        return dp[n - 1, m - 1];
    }
}

public class Solution {
    public int UniquePaths(int m, int n) {
        var currentRow = new int[n];
        
        for (int i = 0; i < n; i++) {
            currentRow[i] = 1;
        }
        
        for (int row = 1; row < m; row++) {
            for (int col = 1; col < n; col++) {
                currentRow[col] += currentRow[col - 1];
            }
        }
        
        return currentRow[n - 1];
    }
}