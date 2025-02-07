namespace LeetCodeSolutions.DynamicProgramming;

/*
 * 0509. Fibonacci Number
 * Difficulty: Easy
 * Submission Time: 2025-02-07 17:36:50
 * Created by vahtyah on 2025-02-07 17:37:22
*/
 
public class Solution {
    public int Fib(int n) {
        if (n <= 1) return n;
        
        int prev = 0, current = 1;
        for (int i = 2; i <= n; i++) {
            current += prev;
            prev = current - prev;
        }
        
        return current;
    }
}