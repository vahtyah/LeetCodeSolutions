namespace LeetCodeSolutions.SlidingWindow;

/*
 * 2799. Count Complete Subarrays in an Array
 * Difficulty: Medium
 * Submission Time: 2025-04-24 04:14:58
 * Created by vahtyah on 2025-04-24 04:15:23
*/
 
public class Solution {
    public int CountCompleteSubarrays(int[] nums) {
        int n = nums.Length;
        int distinctCount = 0;
        bool[] exists = new bool[2001];
        int totalDistinct = 0;
        
        foreach (int num in nums) {
            if (!exists[num]) {
                exists[num] = true;
                totalDistinct++;
            }
        }
        
        if (distinctCount == n) return 1;
        if (distinctCount == 1) return n * (n + 1) / 2;

        int result = 0;
        int[] frequency = new int[2001];
        int left = 0;
        int currentDistinct = 0;
        
        for (int right = 0; right < n; right++) {
            if (frequency[nums[right]]++ == 0) {
                currentDistinct++;
            }
            
            while (currentDistinct == totalDistinct) {
                result += n - right;
                if (--frequency[nums[left++]] == 0) {
                    currentDistinct--;
                }
            }
        }
        
        return result;
    }
}