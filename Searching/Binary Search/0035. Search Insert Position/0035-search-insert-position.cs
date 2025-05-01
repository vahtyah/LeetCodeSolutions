namespace LeetCodeSolutions.Searching/BinarySearch;

/*
 * 0035. Search Insert Position
 * Difficulty: Easy
 * Submission Time: 2025-05-01 19:20:03
 * Created by vahtyah on 2025-05-01 19:20:27
*/
 
public class Solution {
    public int SearchInsert(int[] nums, int target) {
        var right = nums.Length;
        var left = 0;
        
        if (target <= nums[0]) return 0;
        if (target > nums[right - 1]) return right;

        while(left < right){
            var mid = left + ((right - left) >> 1);
            if(nums[mid] == target) return mid;
            if(nums[mid] > target) right = mid;
            else left = mid + 1;
        }

        return left;
    }
}