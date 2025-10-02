namespace LeetCodeSolutions.Math;

/*
 * 3100. Water Bottles II
 * Difficulty: Medium
 * Submission Time: 2025-10-02 11:51:03
 * Created by vahtyah on 2025-10-02 12:11:09
*/
 
public class Solution
{
    public int MaxBottlesDrunk(int numBottles, int numExchange)
    {
        int coefA = 1;
        int coefB = 2 * numExchange - 3;
        int coefC = -2 * numBottles;
        double discriminant = coefB * coefB - 4.0 * coefA * coefC;
        int maxExchangeTimes = (int)Math.Ceiling((-coefB + Math.Sqrt(discriminant)) / (2 * coefA));
        return numBottles + maxExchangeTimes - 1;
    }
}