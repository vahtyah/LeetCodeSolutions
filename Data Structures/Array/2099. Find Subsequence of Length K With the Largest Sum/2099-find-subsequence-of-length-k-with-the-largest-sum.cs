namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 2099. Find Subsequence of Length K With the Largest Sum
 * Difficulty: Easy
 * Submission Time: 2025-06-28 07:24:42
 * Created by vahtyah on 2025-06-28 07:25:02
*/
 
public class Solution {
    public int[] MaxSubsequence(int[] nums, int k) {
        var n = nums.Length;

        if (k == n) return nums;

        var indices = new int[n];
        for (int i = 0; i < n; i++) indices[i] = i;

        Array.Sort(indices, new ValueComparer(nums));
        Array.Sort(indices, n - k, k);

        var result = new int[k];
        for (int i = 0; i < k; i++) {
            result[i] = nums[indices[n - k + i]];
        }

        return result;
    }

    private struct ValueComparer : IComparer<int> {
        private readonly int[] _nums;
        
        public ValueComparer(int[] nums) {
            _nums = nums;
        }
        
        public int Compare(int x, int y) {
            return _nums[x].CompareTo(_nums[y]);
        }
    }
}