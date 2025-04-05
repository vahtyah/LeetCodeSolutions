namespace LeetCodeSolutions.BitManipulation;

/*
 * 1863. Sum of All Subset XOR Totals
 * Difficulty: Easy
 * Submission Time: 2025-04-05 05:32:39
 * Created by vahtyah on 2025-04-05 05:33:00
*/
 
public class Solution {
    public int SubsetXORSum(int[] nums) {
        if (nums.Length == 0) return 0;
        
        int bitOR = 0;
        foreach (int num in nums) {
            bitOR |= num;
        }
        
        // Each bit set in bitOR will contribute to half of all subsets
        // So multiply by 2^(n-1)
        return bitOR * (1 << (nums.Length - 1));
    }
}