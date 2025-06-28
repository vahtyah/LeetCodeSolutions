namespace LeetCodeSolutions.BitManipulation;

/*
 * 0137. Single Number II
 * Difficulty: Medium
 * Submission Time: 2025-06-28 07:49:44
 * Created by vahtyah on 2025-06-28 07:50:14
*/
 
public class Solution {
    public int SingleNumber(int[] nums) {
        int ones = 0, twos = 0;

        foreach(var num in nums){
            ones = (ones ^ num) & ~twos;
            twos = (twos ^ num) & ~ones;
        }

        return ones;
    }
}