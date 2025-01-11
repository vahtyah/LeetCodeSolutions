public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {
        
        int m = text1.Length;
        int n = text2.Length;
        
        int[,] dp = new int[m + 1, n + 1];
        
        for (int i = 1; i <= m; i++) {
            for (int j = 1; j <= n; j++) {
                if (text1[i - 1] == text2[j - 1]) {
                    dp[i,j] = dp[i - 1, j - 1] + 1;
                }
                else {
                    dp[i,j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                }
            }
        }
        
        return dp[m,n];
    }
}

// Optimization
public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {
        if (text1 == text2) return text1.Length;
        // Ensure text1 is the shorter string
        if (text1.Length > text2.Length) {
            string temp = text1;
            text1 = text2;
            text2 = temp;
        }
        
        int m = text1.Length;
        int n = text2.Length;
        // If there are no common characters, return 0
        if (!HasCommonChars(text1, text2)) return 0;

        // Find common prefix and suffix to reduce problem size
        int prefixLen = GetCommonPrefixLength(text1, text2);
        int suffixLen = GetCommonSuffixLength(text1, prefixLen, text2, prefixLen);
        
        // If the common prefix and suffix cover the entire string, return the length of the shorter string
        if (prefixLen + suffixLen >= Math.Min(m, n)) {
            return Math.Min(m, n);
        }
        
        // Remove common prefix and suffix
        text1 = text1.Substring(prefixLen, m - prefixLen - suffixLen);
        text2 = text2.Substring(prefixLen, n - prefixLen - suffixLen);
        
        m = text1.Length;
        n = text2.Length;
        
        int[] dp = new int[n + 1];
        
        for (int i = 1; i <= m; i++) {
            int prev = 0;
            for (int j = 1; j <= n; j++) {
                int temp = dp[j];
                if (text1[i - 1] == text2[j - 1]) {
                    dp[j] = prev + 1;
                }
                else {
                    dp[j] = Math.Max(dp[j], dp[j - 1]);
                }
                prev = temp;
            }
        }
        
        return dp[n] + prefixLen + suffixLen;
    }
    
    private bool HasCommonChars(string s1, string s2) {
        bool[] chars = new bool[128]; // Assuming ASCII
        
        for (int i = 0; i < s1.Length; i++) {
            chars[s1[i]] = true;
        }
        
        for (int i = 0; i < s2.Length; i++) {
            if (chars[s2[i]]) return true;
        }
        
        return false;
    }
    
    private int GetCommonPrefixLength(string s1, string s2) {
        int len = 0;
        int minLen = Math.Min(s1.Length, s2.Length);
        
        while (len < minLen && s1[len] == s2[len]) {
            len++;
        }
        
        return len;
    }
    
    private int GetCommonSuffixLength(string s1, int s1Start, string s2, int s2Start) {
        int len = 0;
        int i = s1.Length - 1;
        int j = s2.Length - 1;
        
        while (i >= s1Start && j >= s2Start && s1[i] == s2[j]) {
            len++;
            i--;
            j--;
        }
        
        return len;
    }
}