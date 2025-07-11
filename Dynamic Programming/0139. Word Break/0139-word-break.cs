namespace LeetCodeSolutions.DynamicProgramming;

/*
 * 0139. Word Break
 * Difficulty: Medium
 * Submission Time: 2025-07-11 19:29:22
 * Created by vahtyah on 2025-07-11 19:29:44
*/
 
public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        var wordSet = new HashSet<string>(wordDict);

        var n = s.Length;

        var dp = new bool[n + 1];
        dp[0] = true;

        var maxWordLen = 0;
        foreach (var word in wordDict)
            if (word.Length > maxWordLen) maxWordLen = word.Length;

        for (int i = 1; i <= n; i++) {
            for (int len = 1; len <= maxWordLen && len <= i; len++) {
                if (!dp[i - len]) continue;
                if (wordSet.Contains(s.Substring(i - len, len))) {
                    dp[i] = true;
                    break;
                }
            }
        }

        return dp[n];
    }
}