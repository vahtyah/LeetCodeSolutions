namespace LeetCodeSolutions.BitManipulation;

/*
 * 1930. Unique Length-3 Palindromic Subsequences
 * Difficulty: Medium
 * Submission Time: 2025-11-21 16:10:34
 * Created by vahtyah on 2025-11-21 16:11:25
*/
 
public class Solution {
    public int CountPalindromicSubsequence(string s) {
        var result = 0;
        
        for(int i = 0; i < 26; i++){
            var left = s.IndexOf((char)(i + 'a'));
            var right = s.LastIndexOf((char)(i + 'a'));

            if(left == -1 || left++ == right) continue;

            var seenMask = 0;
            while(left != right){
                var cur = s[left++] - 'a';
                if(((seenMask >> cur) & 1) == 0) result++;
                seenMask |= 1 << cur;
            }
        }

        return result;
    }
}