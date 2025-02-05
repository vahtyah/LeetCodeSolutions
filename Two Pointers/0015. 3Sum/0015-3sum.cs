namespace LeetCodeSolutions.TwoPointers;

/*
 * 0015. 3Sum
 * Difficulty: Medium
 * Submission Time: 2025-02-05 14:44:03
 * Created by vahtyah on 2025-02-05 14:44:28
 */
 
public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        var result = new List<IList<int>>(nums.Length / 3);
        Array.Sort(nums);
        
        int n = nums.Length;
        for (int i = 0; i < n - 2 && nums[i] <= 0; i++) {
            if (i > 0 && nums[i] == nums[i - 1]) 
                continue;

            int target = -nums[i];
            int left = i + 1;
            int right = n - 1;

            while (left < right) {
                int sum = nums[left] + nums[right];
                
                if (sum == target) {
                    result.Add(new int[] { nums[i], nums[left], nums[right] });
                    
                    do { left++; } while (left < right && nums[left] == nums[left - 1]);
                    do { right--; } while (left < right && nums[right] == nums[right + 1]);
                }
                else if (sum < target) {
                    left++;
                }
                else {
                    right--;
                }
            }
        }
        
        return result;
    }
}