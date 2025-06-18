namespace LeetCodeSolutions.Greedy;

/*
 * 2966. Divide Array Into Arrays With Max Difference
 * Difficulty: Medium
 * Submission Time: 2025-06-18 06:19:41
 * Created by vahtyah on 2025-06-18 06:20:25
*/
 
public class Solution {
    public int[][] DivideArray(int[] nums, int k) {
        Array.Sort(nums);
        
        var result = new int[nums.Length / 3][];
        
        for (int i = 0, idx = 0; i < nums.Length; i += 3, idx++) {
            if (nums[i + 2] - nums[i] > k) {
                return Array.Empty<int[]>();
            }
            result[idx] = new int[] { nums[i], nums[i + 1], nums[i + 2] };
        }
        
        return result;
    }
}