namespace LeetCodeSolutions.DynamicProgramming;

/*
 * 0070. Climbing Stairs
 * Difficulty: Easy
 * Submission Time: 2024-12-29 08:15:56
 * Created by vahtyah on 2025-06-01 05:42:30
*/
 
public class Solution {
    public int ClimbStairs(int n) {
        if(n <= 2) return n;
        int pre = 1;
        int result = 2;

        for(int i = 2; i < n; i++){
            result += pre;
            pre = result - pre;
        }

        return result;
    }
}