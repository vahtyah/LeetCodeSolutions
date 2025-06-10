namespace LeetCodeSolutions.DataStructures/HashTable;

/*
 * 3442. Maximum Difference Between Even and Odd Frequency I
 * Difficulty: Easy
 * Submission Time: 2025-06-10 07:19:28
 * Created by vahtyah on 2025-06-10 07:20:16
*/
 
public class Solution {
    public int MaxDifference(string s) {
        Span<int> freq = stackalloc int[26];
        
        foreach (char c in s) freq[c - 'a']++;
        
        int maxOdd = -1;
        int minEven = int.MaxValue;
        
        for (int i = 0; i < 26; i++) {
            if (freq[i] > 0) {
                if (freq[i] % 2 == 1) {
                    maxOdd = Math.Max(maxOdd, freq[i]);
                } else {
                    minEven = Math.Min(minEven, freq[i]);
                }
            }
        }
        
        return maxOdd - minEven;
    }
}