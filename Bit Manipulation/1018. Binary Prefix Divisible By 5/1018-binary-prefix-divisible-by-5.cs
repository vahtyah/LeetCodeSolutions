namespace LeetCodeSolutions.BitManipulation;

/*
 * 1018. Binary Prefix Divisible By 5
 * Difficulty: Easy
 * Submission Time: 2025-11-24 16:21:12
 * Created by vahtyah on 2025-11-24 16:21:36
*/
 
public class Solution {
    public IList<bool> PrefixesDivBy5(int[] nums) {
        var n = nums.Length;

        var result = new bool[n];
        var bit = 0L;

        for(int i = 0; i < n; i++){
            bit = ((bit << 1) | nums[i]) % 5;
            result[i] = bit % 5 == 0;
        }

        return result;
    }
}