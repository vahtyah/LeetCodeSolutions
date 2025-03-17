namespace LeetCodeSolutions.BitManipulation;

/*
 * 2206. Divide Array Into Equal Pairs
 * Difficulty: Easy
 * Submission Time: 2025-03-17 04:07:17
 * Created by vahtyah on 2025-03-17 04:08:48
*/
 
public class Solution {
    public bool DivideArray(int[] nums) {
        var xor = new int[501];
        var countDiff = 0;

        foreach(var num in nums){
            xor[num] ^= num;
            if(xor[num] == 0) countDiff--;
            else countDiff++;
        }

        return countDiff == 0;
    }
}