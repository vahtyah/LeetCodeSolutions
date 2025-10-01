namespace LeetCodeSolutions.Math;

/*
 * 1518. Water Bottles
 * Difficulty: Easy
 * Submission Time: 2025-10-01 05:45:50
 * Created by vahtyah on 2025-10-01 13:02:33
*/
 
public class Solution {
    public int NumWaterBottles(int numBottles, int numExchange) {
        var result = numBottles;
        
        while(numBottles > 0){
            result += numBottles / numExchange;
            var remainder = 0;
            if(numBottles >= numExchange) remainder = numBottles % numExchange;
            numBottles /= numExchange;
            numBottles += remainder;
        }

        return result;
    }
}