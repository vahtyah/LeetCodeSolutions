namespace LeetCodeSolutions.PrefixSum;

/*
 * 3356. Zero Array Transformation II
 * Difficulty: Medium
 * Submission Time: 2025-03-13 04:49:36
 * Created by vahtyah on 2025-03-13 04:49:55
*/
 
public class Solution {
    public int MinZeroArray(int[] nums, int[][] queries) {
 		int len = nums.Length, qLen = queries.Length, sum = 0, k = 0;
		if(len == 0) return 0;

        int[] rest = new int[len + 1];

        for(int i = 0; i < len; i++)
        {
            while(sum + rest[i] < nums[i])
            {
                k++;

                if(k - 1 >= qLen)
                    return -1;

                int low = queries[k - 1][0], high = queries[k - 1][1], val = queries[k - 1][2];

                if(high < i) // out of left boundary
                    continue;

                rest[Math.Max(i, low)] += val; // only care should visited
                rest[high + 1] -= val;
            }

            sum += rest[i];
        }

		return k;       
    }
}