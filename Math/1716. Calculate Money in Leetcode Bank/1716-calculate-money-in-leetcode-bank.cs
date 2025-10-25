namespace LeetCodeSolutions.Math;

/*
 * 1716. Calculate Money in Leetcode Bank
 * Difficulty: Easy
 * Submission Time: 2025-10-25 12:46:03
 * Created by vahtyah on 2025-10-25 12:46:24
*/
 
public class Solution {
    public int TotalMoney(int n) {
        var weeks = n / 7;
        var days = n % 7;
        return (days + 1) * days / 2 + weeks * days + weeks * 28 + (weeks - 1) * weeks * 7 / 2;
    }
}