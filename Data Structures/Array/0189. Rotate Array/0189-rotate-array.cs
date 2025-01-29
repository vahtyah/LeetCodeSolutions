namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 0189. Rotate Array
 * Difficulty: Medium
 * Submission Time: 2025-01-29 16:02:43
 * Created by vahtyah on 2025-01-29 16:03:50
 */
 
public class Solution {
    public void Rotate(int[] nums, int k) {
        int n = nums.Length;
        k = k % n;
        
        if (k == 0) return;
        
        Reverse(nums, 0, n - 1);
        // Console.WriteLine(string.Join(" ", nums));
        Reverse(nums, 0, k - 1);
        // Console.WriteLine(string.Join(" ", nums));
        Reverse(nums, k, n - 1);
        // Console.WriteLine(string.Join(" ", nums));

    }

    private void Reverse(int[] nums, int start, int end) {
        while (start < end) {
            nums[start] ^= nums[end];
            nums[end] ^= nums[start];
            nums[start] ^= nums[end];
            start++;
            end--;
        }
    }
}