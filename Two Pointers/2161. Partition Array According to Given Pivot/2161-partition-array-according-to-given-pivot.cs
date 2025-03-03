namespace LeetCodeSolutions.TwoPointers;

/*
 * 2161. Partition Array According to Given Pivot
 * Difficulty: Medium
 * Submission Time: 2025-03-03 05:25:13
 * Created by vahtyah on 2025-03-03 05:25:40
*/
 
public class Solution {
    public int[] PivotArray(int[] nums, int pivot) {
        var n = nums.Length;
        var result = new int[n];
        var left = 0;
        var right = n - 1;

        for(int i = 0, j = n - 1; i < n; i++, j--){
            if(nums[i] < pivot) result[left++] = nums[i];
            if(nums[j] > pivot) result[right--] = nums[j];
        }

        while(left <= right) result[left++] = pivot;

        return result;
    }
}