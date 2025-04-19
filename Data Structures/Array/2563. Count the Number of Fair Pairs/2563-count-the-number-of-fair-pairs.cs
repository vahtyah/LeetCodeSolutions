namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 2563. Count the Number of Fair Pairs
 * Difficulty: Medium
 * Submission Time: 2025-04-19 06:35:12
 * Created by vahtyah on 2025-04-19 06:35:59
*/
 
public class Solution {
    public long CountFairPairs(int[] nums, int lower, int upper) {
        Array.Sort(nums);
        return CountLess(nums, upper) - CountLess(nums, lower-1);
    }

    private long CountLess(int[] nums, int val)
    {
        long res = 0;
        int len = nums.Length;
        for(int i = 0, j = len - 1; i < j; i++)
        {
            while(i < j && nums[i] + nums[j] > val) j--;
            res += j - i;
        }
        return res;
    }
}