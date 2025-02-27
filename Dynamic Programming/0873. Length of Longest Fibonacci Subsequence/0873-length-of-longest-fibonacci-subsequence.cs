namespace LeetCodeSolutions.DynamicProgramming;

/*
 * 0873. Length of Longest Fibonacci Subsequence
 * Difficulty: Medium
 * Submission Time: 2025-02-27 07:23:01
 * Created by vahtyah on 2025-02-27 07:25:34
*/
 
public class Solution {
    public int LenLongestFibSubseq(int[] arr) {
        int n = arr.Length;
        var valueToIndex = new Dictionary<int, int>(n);
        for (int i = 0; i < n; i++) {
            valueToIndex[arr[i]] = i;
        }
        
        int maxLength = 0;
        var dp = new Dictionary<(int, int), int>();
        
        for (int i = 0; i < n - 1; i++) {
            for (int j = i + 1; j < n; j++) {
                int a = arr[i];
                int b = arr[j];
                
                int prev = b - a;
                if (prev < a && valueToIndex.TryGetValue(prev, out int prevIndex)) {
                    var length = dp.GetValueOrDefault((prevIndex, i), 2) + 1;
                    dp[(i, j)] = length;
                    maxLength = Math.Max(maxLength, length);
                }
            }
        }
        
        return maxLength >= 3 ? maxLength : 0;
    }
}