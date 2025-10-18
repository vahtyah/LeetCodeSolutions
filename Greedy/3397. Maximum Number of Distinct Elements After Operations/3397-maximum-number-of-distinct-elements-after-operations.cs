namespace LeetCodeSolutions.Greedy;

/*
 * 3397. Maximum Number of Distinct Elements After Operations
 * Difficulty: Medium
 * Submission Time: 2025-10-18 13:11:13
 * Created by vahtyah on 2025-10-18 13:11:45
*/
 
public class Solution {
    public int MaxDistinctElements(int[] nums, int k) {
        Array.Sort(nums);
        int cnt = 0;
        int prev = int.MinValue;
        foreach (int num in nums)
        {
            int curr = Math.Min(Math.Max(num - k, prev + 1), num + k);
            if (curr > prev)
            {
                cnt++;
                prev = curr;
            }
        }
        return cnt;
    }
}