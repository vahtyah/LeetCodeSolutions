namespace LeetCodeSolutions.DynamicProgramming;

/*
 * 2110. Number of Smooth Descent Periods of a Stock
 * Difficulty: Medium
 * Submission Time: 2025-12-15 16:31:52
 * Created by vahtyah on 2025-12-15 16:32:19
*/
 
public class Solution {
    public long GetDescentPeriods(int[] prices) {
        var continous = 1;
        var result = 1L;

        for(int i = 1; i < prices.Length; i++){
            if(prices[i - 1] - prices[i] == 1){
                result += continous;
                continous++;
            }
            else continous = 1;

            result++;
        }

        return result;
    }
}