namespace LeetCodeSolutions.DataStructures/HashTable;

/*
 * 2154. Keep Multiplying Found Values by Two
 * Difficulty: Easy
 * Submission Time: 2025-11-19 05:22:25
 * Created by vahtyah on 2025-11-19 14:21:25
*/
 
public class Solution {
    public int FindFinalValue(int[] nums, int original) {
        var seen = new bool[1001];

        foreach(var num in nums){
            seen[num] = true;
        }

        while(original < 1001 && seen[original]){
            original *= 2;
        }

        return original;
    }
}