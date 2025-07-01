namespace LeetCodeSolutions.DataStructures/String;

/*
 * 3330. Find the Original Typed String I
 * Difficulty: Easy
 * Submission Time: 2025-07-01 06:30:51
 * Created by vahtyah on 2025-07-01 06:31:29
*/
 
public class Solution {
    public int PossibleStringCount(string word) {
        if (word.Length <= 1) return 1;
        
        ReadOnlySpan<char> span = word.AsSpan();
        int count = 1;
        
        for (int i = 1; i < span.Length; i++) {
            if (span[i] == span[i - 1]) {
                count++;
            }
        }
        
        return count;
    }
}