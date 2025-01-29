namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 0121. Best Time to Buy and Sell Stock
 * Difficulty: Easy
 * Submission Time: 2025-01-29 17:15:57
 * Created by vahtyah on 2025-01-29 17:17:39
 */
 
public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices == null || prices.Length <= 1)
            return 0;
            
        int minPrice = int.MaxValue;
        int maxProfit = 0;
        
        foreach (int price in prices) {
            if (price < minPrice)
                minPrice = price;
            else if (price - minPrice > maxProfit)
                maxProfit = price - minPrice;
        }
        
        return maxProfit;
    }
}