namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 3904. Smallest Stable Index II
 * Difficulty: Medium
 * Submission Time: 2026-09-05 06:48:10
 * Created by vahtyah on 2026-09-05 08:47:02
*/
 
public class Solution {
    public int FirstStableIndex(int[] nums, int k) {
        var n = nums.Length;
        Span<int> postfix = stackalloc int[n];
        postfix[n - 1] = nums[n - 1]; 

        for(int i = 1; i < n; i++){
            postfix[n - i - 1] = nums[n - i - 1] > postfix[n - i] ? postfix[n - i] : nums[n - i - 1];
        }

        var maximum = nums[0];

        for(int i = 0; i < n; i++){
            if(maximum < nums[i]) maximum = nums[i];
            var score = maximum - postfix[i];
            if(score <= k) return i;
        }

        return -1;
    }
}