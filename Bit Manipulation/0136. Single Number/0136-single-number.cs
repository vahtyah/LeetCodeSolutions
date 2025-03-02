namespace LeetCodeSolutions.BitManipulation;

/*
 * 0136. Single Number
 * Difficulty: Easy
 * Submission Time: 2025-01-15 20:24:59
 * Created by vahtyah on 2025-03-02 09:46:34
*/
 
public class Solution {
    public int SingleNumber(int[] nums) {
        int result = 0;
        
        foreach(int num in nums) {
            result ^= num;
        }
        
        return result;
    }
}