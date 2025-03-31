namespace LeetCodeSolutions.Greedy;

/*
 * 2551. Put Marbles in Bags
 * Difficulty: Hard
 * Submission Time: 2025-03-31 04:51:25
 * Created by vahtyah on 2025-03-31 04:51:54
*/
 
public class Solution {
    public long PutMarbles(int[] weights, int k) {
        var n = weights.Length;
        var partitionCosts = new long[n - 1];
        for(var i = 1; i < n; i++){
            partitionCosts[i - 1] = weights[i - 1] + weights[i];
        }

        Array.Sort(partitionCosts);
        long maxScore = weights[0] + weights[n - 1];
        long minScore = maxScore;

        for(int i = 0; i < k - 1; i++){
            minScore += partitionCosts[i];
            maxScore += partitionCosts[n - 2 - i];
        }

        return maxScore - minScore;
    }
}