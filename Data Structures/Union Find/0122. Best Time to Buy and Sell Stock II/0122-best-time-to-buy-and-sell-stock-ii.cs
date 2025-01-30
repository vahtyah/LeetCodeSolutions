namespace LeetCodeSolutions.DataStructures/UnionFind;

/*
 * 0122. Best Time to Buy and Sell Stock II
 * Difficulty: Medium
 * Submission Time: 2025-01-29 17:49:20
 * Created by vahtyah on 2025-01-30 07:33:41
 */
 
public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices.Length <= 1) return 0;

        var cash = 0;
        var hold = -prices[0];

        for(int i = prices.Length - 1; i >= 0; i--){
            var holdTmp = hold;
            hold = Math.Max(hold, cash + prices[i]);
            cash = Math.Max(cash, holdTmp - prices[i]);
        }

        return cash;
    }
}