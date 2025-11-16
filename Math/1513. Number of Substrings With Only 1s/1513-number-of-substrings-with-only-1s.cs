namespace LeetCodeSolutions.Math;

/*
 * 1513. Number of Substrings With Only 1s
 * Difficulty: Medium
 * Submission Time: 2025-11-16 01:52:36
 * Created by vahtyah on 2025-11-16 09:43:22
*/
 
public class Solution {
    private const int MOD = 1_000_000_007;
    public int NumSub(string s) {
        var currentOnes = 0;
        var sub = 0L;

        foreach(var c in s){
            if(c == '0') currentOnes = 0;
            else sub = (sub + ++currentOnes);
        }

        return (int)(sub % MOD);
    }
}