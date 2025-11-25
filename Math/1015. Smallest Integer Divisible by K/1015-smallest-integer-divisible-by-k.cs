namespace LeetCodeSolutions.Math;

/*
 * 1015. Smallest Integer Divisible by K
 * Difficulty: Medium
 * Submission Time: 2025-11-25 05:32:17
 * Created by vahtyah on 2025-11-25 14:55:14
*/
 
public class Solution {
    public int SmallestRepunitDivByK(int k) {
        if((k & 1) == 0 || k % 5 == 0) return -1;

        var remainder = 1 % k;
        var result = 1;

        while(remainder != 0){
            remainder = (remainder * 10 + 1) % k;
            result++;
        }

        return result;
    }
}