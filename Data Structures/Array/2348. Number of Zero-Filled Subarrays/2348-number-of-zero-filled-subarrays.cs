namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 2348. Number of Zero-Filled Subarrays
 * Difficulty: Medium
 * Submission Time: 2025-08-19 15:35:22
 * Created by vahtyah on 2025-08-19 15:36:28
*/
 
public class Solution {
    public long ZeroFilledSubarray(int[] nums) {
        long run = 0, result = 0;

        foreach(var num in nums){
            if(num == 0) run++;
            else run = 0;
            
            result += run;
        }

        return result;
    }
}