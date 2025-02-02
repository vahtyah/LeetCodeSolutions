namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 1752. Check if Array Is Sorted and Rotated
 * Difficulty: Easy
 * Submission Time: 2025-02-02 07:43:33
 * Created by vahtyah on 2025-02-02 07:45:19
 */
 
public class Solution {
    public bool Check(int[] nums) {
        int irregularities = 0;
        int n = nums.Length;
        
        for (int i = 0; i < n; i++) {
            if (nums[i] > nums[(i + 1) % n]) {
                irregularities++;
            }
            if (irregularities > 1) {
                return false;
            }
        }
        
        return true;
    }
}