namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 3190. Find Minimum Operations to Make All Elements Divisible by Three
 * Difficulty: Easy
 * Submission Time: 2025-11-22 09:45:20
 * Created by vahtyah on 2025-11-23 12:47:37
*/
 
public class Solution {
    public int MinimumOperations(int[] nums) {
        var operations = 0;
        
        foreach(var num in nums){
            operations += Math.Min(num % 3, 3 - (num % 3));
        }

        return operations;
    }
}