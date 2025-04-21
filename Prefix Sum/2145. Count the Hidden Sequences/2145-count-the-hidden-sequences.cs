namespace LeetCodeSolutions.PrefixSum;

/*
 * 2145. Count the Hidden Sequences
 * Difficulty: Medium
 * Submission Time: 2025-04-21 07:41:27
 * Created by vahtyah on 2025-04-21 07:41:59
*/
 
public class Solution {
    public int NumberOfArrays(int[] differences, int lower, int upper) {
        long runningSum = 0;
        long minVal = 0;
        long maxVal = 0;

        foreach (int diff in differences) {
            runningSum += diff;
            if(minVal > runningSum) minVal = runningSum;
            if(maxVal < runningSum) maxVal = runningSum;
        }
        
        long count = (long)(upper) - (long)lower - maxVal + minVal + 1;
        if (count < 0) count = 0;
        return (int)count;
    }
}