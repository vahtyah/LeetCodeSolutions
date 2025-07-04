namespace LeetCodeSolutions.Math;

/*
 * 0172. Factorial Trailing Zeroes
 * Difficulty: Medium
 * Submission Time: 2025-07-04 08:41:20
 * Created by vahtyah on 2025-07-04 08:41:37
*/
 
public class Solution {
    public int TrailingZeroes(int n) {
        var countZeros = 0;

        while(n > 0){
            n /= 5;
            countZeros += n;
        }

        return countZeros;
    }
}