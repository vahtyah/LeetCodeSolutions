namespace LeetCodeSolutions.DynamicProgramming;

/*
 * 0474. Ones and Zeroes
 * Difficulty: Medium
 * Submission Time: 2025-11-11 15:20:57
 * Created by vahtyah on 2025-11-11 15:23:06
*/
 
public class Solution {
    public int FindMaxForm(string[] strs, int m, int n) {
       var dp = new int[m + 1][];
		
		for(int i = 0; i <= m; i++)
		{
			dp[i] = new int[n + 1];
		}

        for(int i = 0; i < strs.Length; i++){
            int ones = 0, zeroes = 0;

            for(int j = 0; j < strs[i].Length; j++){
                if(strs[i][j] == '0') zeroes++;
                else ones++;
            }

            for(int j = m; j >= zeroes; j--){
                for(int k = n; k >= ones; k--){
                    dp[j][k] = Math.Max(dp[j][k], dp[j - zeroes][k - ones] + 1);
                }
            }
        }

        return dp[m][n];
    }
}