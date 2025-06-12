namespace LeetCodeSolutions.Searching/BinarySearch;

/*
 * 0033. Search in Rotated Sorted Array
 * Difficulty: Medium
 * Submission Time: 2025-06-12 17:31:38
 * Created by vahtyah on 2025-06-12 17:32:07
*/
 
public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0, right = nums.Length - 1;
        
        while (left <= right) {
            var mid = left + ((right - left) >> 1); 
            
            if (nums[mid] == target) return mid;
            
            if (nums[left] <= nums[mid]) {
                if (nums[left] <= target && target < nums[mid]) right = mid - 1;
                else left = mid + 1;
            } else {
                if (nums[mid] < target && target <= nums[right]) left = mid + 1;
                else right = mid - 1;
            }
        }
        
        return -1;
    }
}