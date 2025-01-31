namespace LeetCodeSolutions.TwoPointers;

/*
 * 0392. Is Subsequence
 * Difficulty: Easy
 * Submission Time: 2025-01-31 15:28:01
 * Created by vahtyah on 2025-01-31 15:28:37
 */
 
public class Solution {
    public bool IsSubsequence(string s, string t) {
        int j = 0;
        int cnt = 0;
        for(int i = 0; i < t.Length && j < s.Length; i++){
            if(s[j]==t[i]){
                j++;
                cnt++;
            }
        }

        if(cnt == s.Length){
            return true;
        }

        return false;
    }
}