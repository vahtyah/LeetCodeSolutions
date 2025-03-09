namespace LeetCodeSolutions.SlidingWindow;

/*
 * 3208. Alternating Groups II
 * Difficulty: Medium
 * Submission Time: 2025-03-09 06:30:17
 * Created by vahtyah on 2025-03-09 06:30:50
*/
 
public class Solution 
{
    public int NumberOfAlternatingGroups(int[] nums, int k){
        var n = nums.Length;
        var count = 1;
        var result = 0;

        for (int i = 0; i < n - 1 + k - 1; i++)
        {            
            if (nums[i % n] != nums[(i + 1) % n]) count++;
            else count = 1;

            if (count >= k) result++;
        }

        return result;
    }
}