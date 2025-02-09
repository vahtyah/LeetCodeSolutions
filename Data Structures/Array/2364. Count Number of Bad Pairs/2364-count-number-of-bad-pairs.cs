namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 2364. Count Number of Bad Pairs
 * Difficulty: Medium
 * Submission Time: 2025-02-09 06:48:14
 * Created by vahtyah on 2025-02-09 06:51:24
*/
 
public class Solution {
    public long CountBadPairs(int[] nums) {
        var freq = new Dictionary<int, int>(nums.Length);
        var badPairs = 0L;
        
        for (var i = 0; i < nums.Length; i++)
        {
            var diff = nums[i] - i;
            var goodPairs = freq[diff] = freq.GetValueOrDefault(diff) + 1;
            badPairs += i - goodPairs + 1;
        }

        return badPairs;
    }
}