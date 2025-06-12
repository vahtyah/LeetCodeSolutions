namespace LeetCodeSolutions.Searching/BinarySearch;

/*
 * 0034. Find First and Last Position of Element in Sorted Array
 * Difficulty: Medium
 * Submission Time: 2025-06-12 17:51:43
 * Created by vahtyah on 2025-06-12 17:53:19
*/
 
public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        if(nums.Length == 0) return new int[] {-1, -1};
        if(nums[0] > target || nums[nums.Length - 1] < target) return new int[] {-1, -1};
        return new int[] {FindLeft(nums, target), FindRight(nums, target)};
    }

    public int FindLeft(int[] nums, int target){
        int left = 0, right = nums.Length - 1;

        while(left <= right){
            var mid = left + ((right - left) >> 1);
            if(nums[mid] < target) left = mid + 1;
            else right = mid - 1;
        }

        return nums[left] == target ? left : -1;
    }

    public int FindRight(int[] nums, int target){
        int left = 0, right = nums.Length - 1;

        while(left <= right){
            var mid = left + ((right - left) >> 1);
            if(nums[mid] > target) right = mid - 1;
            else left = mid + 1;
        }

        return nums[right] == target ? right : -1;
    }
}