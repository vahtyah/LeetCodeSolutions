namespace LeetCodeSolutions.SlidingWindow;

/*
 * 1695. Maximum Erasure Value
 * Difficulty: Medium
 * Submission Time: 2025-07-22 08:26:26
 * Created by vahtyah on 2025-07-22 08:26:50
*/
 
public class Solution {
    public int MaximumUniqueSubarray(int[] nums) {
        Span<bool> seen = stackalloc bool[10001];
        var sumSoFar = 0;
        var maxSum = 0;

        for(int left = 0, right = 0; right < nums.Length; right++){
            if(seen[nums[right]]){
                maxSum = Math.Max(maxSum, sumSoFar);
                while(nums[left] != nums[right]){
                    seen[nums[left]] = false;
                    sumSoFar -= nums[left++];
                }
                left++;
            }
            else{
                sumSoFar += nums[right];
                seen[nums[right]] = true;
            }
        }
        maxSum = Math.Max(maxSum, sumSoFar);

        return maxSum;
    }
}