namespace LeetCodeSolutions.DataStructures/HashTable;

/*
 * 3375. Minimum Operations to Make Array Values Equal to K
 * Difficulty: Easy
 * Submission Time: 2025-04-09 04:40:53
 * Created by vahtyah on 2025-04-09 04:41:15
*/
 
public class Solution {
    public int MinOperations(int[] nums, int k) {
        var numApear = new bool[101];
        var operations = 0;

        foreach(var num in nums){
            if(num < k) return -1;
            if(!numApear[num] && num != k){
                operations++;
            }
            numApear[num] = true;
        }

        return operations;
    }
}