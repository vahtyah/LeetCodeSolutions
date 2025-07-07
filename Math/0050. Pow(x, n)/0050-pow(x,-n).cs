namespace LeetCodeSolutions.Math;

/*
 * 0050. Pow(x, n)
 * Difficulty: Medium
 * Submission Time: 2025-07-07 14:22:07
 * Created by vahtyah on 2025-07-07 14:24:35
*/
 
public class Solution {
    public double MyPow(double x, int n) {
        long N = n;
        if(N < 0){
            x = 1 / x;
            N = -N;
        }

        double current = x;
        double result = 1;

        for(long i = N; i > 0; i /= 2){
            if((i & 1) == 1) result *= current;
            current *= current;
        }

        return result;
    }
}