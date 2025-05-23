namespace LeetCodeSolutions.Greedy;

/*
 * 3068. Find the Maximum Sum of Node Values
 * Difficulty: Hard
 * Submission Time: 2025-05-23 06:23:35
 * Created by vahtyah on 2025-05-23 06:25:03
*/
 
public class Solution
{
    public long MaximumValueSum(int[] nums, int k, int[][] edges)
    {
        /*
        As the graph is a tree, we can always flip an even number of nodes 
        (no need to care about the edges) to get a larger sum.
        That is, if count(num ^ k > num for num in nums) is even, 
        we can return the maximum sum possible.
        For the case in which this count is odd, we have to reduce the maxSum 
        by min(abs(num ^ k - num)), which points to the node in which num is 
        closest to num ^ k.
        */
        
        int count = 0;
        long maxSum = 0;
        int sacrifice = int.MaxValue;

        foreach (var num in nums)
        {
            if ((num ^ k) > num) count++;
            sacrifice = Math.Min(sacrifice, Math.Abs((num ^ k) - num));
            maxSum += Math.Max(num, num ^ k);
        }

        if (count % 2 != 0) maxSum -= sacrifice;

        return maxSum;
    }
}