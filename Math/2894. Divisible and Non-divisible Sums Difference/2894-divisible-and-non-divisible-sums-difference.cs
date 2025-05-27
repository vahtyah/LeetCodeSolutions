namespace LeetCodeSolutions.Math;

/*
 * 2894. Divisible and Non-divisible Sums Difference
 * Difficulty: Easy
 * Submission Time: 2025-05-27 02:48:06
 * Created by vahtyah on 2025-05-27 02:51:01
*/
 
public class Solution {
    public int DifferenceOfSums(int n, int m) {
        var totalSum = n * (n + 1) / 2;
        var multiplesCount = n / m;
        var multiplesSum = m * multiplesCount * (multiplesCount + 1) / 2;
        
        return totalSum - 2 * multiplesSum;
    }
}