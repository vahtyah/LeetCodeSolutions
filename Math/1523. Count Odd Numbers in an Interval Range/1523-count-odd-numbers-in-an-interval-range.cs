namespace LeetCodeSolutions.Math;

/*
 * 1523. Count Odd Numbers in an Interval Range
 * Difficulty: Easy
 * Submission Time: 2025-12-07 02:48:57
 * Created by vahtyah on 2025-12-07 05:28:19
*/
 
public class Solution {
    public int CountOdds(int low, int high) {
        var num = high - low + 1;
        if((num & 1) == 0) return num / 2;
        return num / 2 + (low % 2 == 0 ? 0 : 1);
    }
}