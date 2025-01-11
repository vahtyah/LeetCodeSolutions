public class Solution {
    public int MaxProfit(int[] prices, int fee) {
        if (prices == null || prices.Length <= 1)
            return 0;
            
        int n = prices.Length;
        // dp[i][0] represents maximum profit at day i without holding stock
        // dp[i][1] represents maximum profit at day i with holding stock
        int[,] dp = new int[n, 2];
        
        // Base case - day 0
        dp[0, 0] = 0;  // not holding any stock
        dp[0, 1] = -prices[0];  // buy stock on day 0
        
        // Fill dp table
        for (int i = 1; i < n; i++) {
            // If not holding stock at day i:
            // 1. Keep previous state (not holding)
            // 2. Sell stock (held from previous day)
            dp[i, 0] = Math.Max(dp[i-1, 0], dp[i-1, 1] + prices[i] - fee);
            
            // If holding stock at day i:
            // 1. Keep holding stock from previous day
            // 2. Buy new stock using cash from previous day
            dp[i, 1] = Math.Max(dp[i-1, 1], dp[i-1, 0] - prices[i]);
        }
        
        // Return maximum profit without holding stock on last day
        return dp[n-1, 0];
    }
}

public class Solution {
    public int MaxProfit(int[] prices, int fee) {
        if (prices == null || prices.Length <= 1)
            return 0;
            
        int cash = 0; 
        int hold = -prices[0];
        
        for (int i = prices.Length - 1; i >= 0; i--) {
            var holdTmp = hold;
            hold = Math.Max(hold, cash + prices[i]);
            cash = Math.Max(cash, holdTmp - prices[i] - fee);
        }
        
        return cash; 
    }
}