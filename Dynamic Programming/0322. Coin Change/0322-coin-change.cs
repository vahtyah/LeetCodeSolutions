namespace LeetCodeSolutions.DynamicProgramming;

/*
 * 0322. Coin Change
 * Difficulty: Medium
 * Submission Time: 2025-07-20 08:05:42
 * Created by vahtyah on 2025-07-20 08:12:33
*/
 
public class Solution {
    public int CoinChange(int[] coins, int amount) {
        var n = coins.Length;
        if(amount == 0) return 0;
        
        Span<int> dp = stackalloc int[amount + 1];

        for(int i = 1; i <= amount; i++){
            var minCoin = amount + 1;
            foreach(var coin in coins){
                if(i < coin) continue;
                var coinsNeeded  = dp[i - coin] + 1;
                if(minCoin > coinsNeeded) minCoin = coinsNeeded;
            }
            dp[i] = minCoin;
        }

        return dp[amount] > amount ? -1 : dp[amount];
    }
}