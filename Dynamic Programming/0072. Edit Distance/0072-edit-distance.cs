public class Solution {
    public int MinDistance(string word1, string word2) {
        var m = word1.Length;
        var n = word2.Length;

        var dp = new int[m + 1, n + 1];

        for(int i = 0; i <= m; i++) dp[i, 0] = i; //Delete

        for(int i = 0; i <= n; i++) dp[0, i] = i; //Insert

        for(var i = 1; i <= m; i++){
            for(var j = 1; j <= n; j++){
                if(word1[i - 1] == word2[j - 1]) //If the characters are the same
                    dp[i, j] = dp[i - 1, j - 1]; //No operation needed
                else{ //If the characters are different
                    dp[i, j] = 1 + Math.Min( //Find the minimum of the three operations
                        dp[i - 1, j - 1],  //Replace
                        Math.Min(
                            dp[i - 1, j],   //Insert
                            dp[i, j - 1]    //Delete
                        )
                    );
                }
            }
        }

        return dp[m, n];
    }
}

//100%
public class Solution {
    public int MinDistance(string word1, string word2) {
        if (word1.Length > word2.Length) { // Ensure word1 is shorter
            string temp = word1;
            word1 = word2;
            word2 = temp;
        }
        
        int m = word1.Length;
        int n = word2.Length;
        
        int[] dp = new int[m + 1];
        
        for (int i = 0; i <= m; i++) { // Initialize dp
            dp[i] = i;
        }
        
        for (int j = 1; j <= n; j++) {
            int prev = dp[0];
            dp[0] = j;
            
            for (int i = 1; i <= m; i++) {
                int temp = dp[i];
                
                if (word1[i - 1] == word2[j - 1]) {
                    dp[i] = prev;
                } else {
                    dp[i] = 1 + Math.Min(prev,          // Thay thế
                        Math.Min(dp[i - 1],      // Chèn
                            dp[i]));          // Xóa
                }
                
                prev = temp;
            }
        }
        
        return dp[m];
    }
}