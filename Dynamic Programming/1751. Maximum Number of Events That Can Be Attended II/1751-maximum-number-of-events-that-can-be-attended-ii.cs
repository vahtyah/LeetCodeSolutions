namespace LeetCodeSolutions.DynamicProgramming;

/*
 * 1751. Maximum Number of Events That Can Be Attended II
 * Difficulty: Hard
 * Submission Time: 2025-07-08 08:31:54
 * Created by vahtyah on 2025-07-08 08:33:20
*/
 
public class Solution {
    public int MaxValue(int[][] events, int k) {
        int n = events.Length;
        Array.Sort(events, (a, b) => a[0] - b[0]);
        
        int[] startDays = events.Select(e => e[0]).ToArray();
        int[,] dp = new int[n + 1, k + 1];

        for (int i = n - 1; i >= 0; --i) {
            int next = UpperBound(startDays, events[i][1]);
            for (int j = 1; j <= k; ++j) {
                dp[i, j] = Math.Max(dp[i + 1, j], events[i][2] + dp[next, j - 1]);
            }
        }
        return dp[0, k];
    }

    private int UpperBound(int[] arr, int target) {
        int low = 0, high = arr.Length;
        while (low < high) {
            int mid = low + ((high - low) >> 2);
            if (arr[mid] <= target)
                low = mid + 1;
            else
                high = mid;
        }
        return low;
    }
}