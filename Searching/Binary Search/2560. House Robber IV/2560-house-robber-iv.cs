namespace LeetCodeSolutions.Searching/BinarySearch;

/*
 * 2560. House Robber IV
 * Difficulty: Medium
 * Submission Time: 2025-03-15 05:26:22
 * Created by vahtyah on 2025-03-15 05:26:47
*/
 
public class Solution {
    public int MinCapability(int[] nums, int k) {
        int left = int.MaxValue;
        int right = int.MinValue;
        
        foreach (int num in nums) {
            left = Math.Min(left, num);
            right = Math.Max(right, num);
        }
        
        while (left < right) {
            int mid = left + (right - left) / 2;
            
            if (CanRobKHouses(nums, k, mid)) {
                right = mid;
            } else {
                left = mid + 1;
            }
        }
        
        return left;
    }
    
    private bool CanRobKHouses(int[] nums, int k, int capability) {
        int count = 0;
        int i = 0;
        int n = nums.Length;
        
        while (i < n) {
            if (nums[i] <= capability) {
                count++;
                i += 2;
                if (count >= k) {
                    return true;
                }
            } else {
                i++; 
            }
            
            if (count + ((n - i + 1) / 2) < k) {
                return false;
            }
        }
        
        return count >= k;
    }
}