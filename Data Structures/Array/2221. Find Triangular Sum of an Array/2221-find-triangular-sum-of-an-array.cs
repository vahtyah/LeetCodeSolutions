namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 2221. Find Triangular Sum of an Array
 * Difficulty: Medium
 * Submission Time: 2025-09-30 11:41:12
 * Created by vahtyah on 2025-09-30 13:19:45
*/
 
public class Solution {
    public unsafe int TriangularSum(int[] nums) {
        var n = nums.Length;

        fixed(int* p = nums){
            for(int i = 1; i < n; i++){
                for(int j = n - 1; j >= i; j--){
                    p[j] = (p[j] + p[j - 1]) % 10;
                }
            }
        }

        return nums[n - 1];
    }
}