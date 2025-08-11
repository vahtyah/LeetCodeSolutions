namespace LeetCodeSolutions.PrefixSum;

/*
 * 2438. Range Product Queries of Powers
 * Difficulty: Medium
 * Submission Time: 2025-08-11 14:50:41
 * Created by vahtyah on 2025-08-11 14:51:27
*/
 
public class Solution {
    private const int MOD = 1000000007;

    public int[] ProductQueries(int n, int[][] queries) {
        var bins = new List<int>();
        int rep = 1;
        while (n > 0) {
            if (n % 2 == 1) {
                bins.Add(rep);
            }
            n /= 2;
            rep *= 2;
        }

        int m = bins.Count;
        int[,] results = new int[m, m];
        for (int i = 0; i < m; i++) {
            long cur = 1;
            for (int j = i; j < m; j++) {
                cur = (cur * bins[j]) % MOD;
                results[i, j] = (int)cur;
            }
        }

        int[] ans = new int[queries.Length];
        for (int i = 0; i < queries.Length; i++) {
            ans[i] = results[queries[i][0], queries[i][1]];
        }
        return ans;
    }
}