namespace LeetCodeSolutions.PrefixSum;

/*
 * 0238. Product of Array Except Self
 * Difficulty: Medium
 * Submission Time: 2024-12-31 15:57:50
 * Created by vahtyah on 2025-01-30 13:18:08
 */
 
public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var answer = new int[nums.Length];
        answer[0] = 1;
        for(int i = 1; i < nums.Length; i++){
            answer[i] = answer[i - 1] * nums[i - 1];
        }
        int suffixProduct = 1;
        for(int i = nums.Length - 1; i >= 0; i--){
            answer[i] *= suffixProduct;
            suffixProduct *= nums[i];
        }
        return answer;
    }
}