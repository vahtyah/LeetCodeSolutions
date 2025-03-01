namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 2460. Apply Operations to an Array
 * Difficulty: Easy
 * Submission Time: 2025-03-01 05:34:18
 * Created by vahtyah on 2025-03-01 05:35:17
*/
 
public class Solution {
    public int[] ApplyOperations(int[] nums) {
        int n = nums.Length;
        
        for (int i = 0; i < n - 1; i++) {
            if (nums[i] == nums[i + 1]) {
                nums[i] *= 2;
                nums[i + 1] = 0;
            }
        }
        
        int nonZeroIndex = 0;
        for (int i = 0; i < n; i++) {
            if (nums[i] != 0) {
                if (i != nonZeroIndex) {
                    nums[nonZeroIndex] = nums[i];
                    nums[i] = 0;
                }
                nonZeroIndex++;
            }
        }
        
        return nums;
    }
}