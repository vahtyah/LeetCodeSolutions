namespace LeetCodeSolutions.DataStructures/HashTable;

/*
 * 3396. Minimum Number of Operations to Make Elements in Array Distinct
 * Difficulty: Easy
 * Submission Time: 2025-04-08 05:39:43
 * Created by vahtyah on 2025-04-08 05:40:13
*/
 
public class Solution {
    public int MinimumOperations(int[] nums) {
        var numFreq = new int[101];

        for(int i = nums.Length - 1; i >= 0; i--){
            if(++numFreq[nums[i]] > 1){
                return (int)Math.Ceiling((float)(i + 1) / 3);
            }
        }
        
        return 0;
    }
}