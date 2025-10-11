namespace LeetCodeSolutions.Math;

/*
 * 3870. Count Commas in Range
 * Difficulty: Easy
 * Submission Time: 2026-09-08 01:55:17
 * Created by vahtyah on 2026-09-08 13:54:47
*/
 
public class Solution {
    public int CountCommas(int n) {
        if(n < 1000) return 0;
        return n - 999;
    }
}