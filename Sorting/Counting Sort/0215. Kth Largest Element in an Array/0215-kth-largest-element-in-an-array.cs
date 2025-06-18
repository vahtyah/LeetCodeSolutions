namespace LeetCodeSolutions.Sorting/CountingSort;

/*
 * 0215. Kth Largest Element in an Array
 * Difficulty: Medium
 * Submission Time: 2025-06-18 07:40:33
 * Created by vahtyah on 2025-06-18 07:41:06
*/
 
public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        int min = int.MaxValue, max = int.MinValue;
        foreach (int num in nums) {
            if (num < min) min = num;
            if (num > max) max = num;
        }
        
        return CountingSortKthLargest(nums, k, min, max);
    }
    
    private int CountingSortKthLargest(int[] nums, int k, int min, int max) {
        int[] count = new int[max - min + 1];
        
        foreach (int num in nums) {
            count[num - min]++;
        }
        
        int remaining = k;
        for (int i = count.Length - 1; i >= 0; i--) {
            remaining -= count[i];
            if (remaining <= 0) {
                return i + min;
            }
        }
        
        throw new InvalidOperationException();
    }
}