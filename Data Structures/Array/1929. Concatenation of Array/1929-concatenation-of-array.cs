namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 1929. Concatenation of Array
 * Difficulty: Easy
 * Submission Time: 2025-11-22 16:43:17
 * Created by vahtyah on 2025-12-11 14:54:27
*/
 
public class Solution {
    public int[] GetConcatenation(int[] nums) {
        var n = nums.Length;
        var ans = new int[2*n];

        for(int i = 0; i < n; i++){
            ans[i] = nums[i];
            ans[i + n] = nums[i];
        }

        return ans;
    }
}