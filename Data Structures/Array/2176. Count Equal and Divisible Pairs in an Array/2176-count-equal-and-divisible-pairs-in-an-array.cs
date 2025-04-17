namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 2176. Count Equal and Divisible Pairs in an Array
 * Difficulty: Easy
 * Submission Time: 2025-04-17 04:27:42
 * Created by vahtyah on 2025-04-17 04:28:08
*/
 
public class Solution {
    public int CountPairs(int[] nums, int k) {
        var count = 0;

        for(int i = 0; i < nums.Length - 1; i++){
            for(int j = i + 1; j < nums.Length; j++){
                if(nums[i] != nums[j]) continue;
                if((i * j) % k == 0) count++;
            }
        }

        return count;
    }
}