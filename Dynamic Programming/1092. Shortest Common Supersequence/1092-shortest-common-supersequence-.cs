namespace LeetCodeSolutions.DynamicProgramming;

/*
 * 1092. Shortest Common Supersequence 
 * Difficulty: Hard
 * Submission Time: 2025-02-28 05:21:39
 * Created by vahtyah on 2025-02-28 05:34:11
*/
 
public class Solution {
    public string ShortestCommonSupersequence(string str1, string str2) {
        int m = str1.Length;
        int n = str2.Length;
        
        if (m == 0) return str2;
        if (n == 0) return str1;
        
        if (IsSubsequence(str1, str2)) return str2;
        if (IsSubsequence(str2, str1)) return str1;
        
        int[,] dp = new int[m + 1, n + 1];
        
        for (int i = 1; i <= m; i++) {
            for (int j = 1; j <= n; j++) {
                if (str1[i - 1] == str2[j - 1]) {
                    dp[i, j] = dp[i - 1, j - 1] + 1;
                } else {
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                }
            }
        }
        
        char[] result = new char[m + n];
        int resultIndex = m + n - 1;
        
        int i1 = m, j1 = n;
        while (i1 > 0 && j1 > 0) {
            if (str1[i1 - 1] == str2[j1 - 1]) {
                result[resultIndex--] = str1[i1 - 1];
                i1--;
                j1--;
            }
            else if (dp[i1 - 1, j1] > dp[i1, j1 - 1]) {
                result[resultIndex--] = str1[i1 - 1];
                i1--;
            } else {
                result[resultIndex--] = str2[j1 - 1];
                j1--;
            }
        }
        
        while (i1 > 0) {
            result[resultIndex--] = str1[i1 - 1];
            i1--;
        }
        
        while (j1 > 0) {
            result[resultIndex--] = str2[j1 - 1];
            j1--;
        }
        
        return new string(result, resultIndex + 1, m + n - resultIndex - 1);
    }
    
    private bool IsSubsequence(string s1, string s2) {
        int i = 0;
        foreach (char c in s2) {
            if (i < s1.Length && c == s1[i]) {
                i++;
            }
        }
        return i == s1.Length;
    }
}