namespace LeetCodeSolutions.Greedy;

/*
 * 0135. Candy
 * Difficulty: Hard
 * Submission Time: 2025-02-01 18:52:01
 * Created by vahtyah on 2025-02-01 18:52:23
 */
 
public class Solution {
    public int Candy(int[] ratings) {
        int n = ratings.Length;
        int[] candies = new int[n];
        
        Array.Fill(candies, 1);
        
        for (int i = 1; i < n; i++) {
            if (ratings[i] > ratings[i - 1]) {
                candies[i] = candies[i - 1] + 1;
            }
        }
        
        for (int i = n - 2; i >= 0; i--) {
            if (ratings[i] > ratings[i + 1]) {
                candies[i] = Math.Max(candies[i], candies[i + 1] + 1);
            }
        }
        
        return candies.Sum();
    }
}