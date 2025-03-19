namespace LeetCodeSolutions.Greedy;

/*
 * 3191. Minimum Operations to Make Binary Array Elements Equal to One I
 * Difficulty: Medium
 * Submission Time: 2025-03-19 05:32:03
 * Created by vahtyah on 2025-03-19 05:32:19
*/
 
public class Solution {
    public int MinOperations(int[] nums) {
        var operations = 0;
        for(int i = 0; i < nums.Length - 2; i++){
            if(nums[i] == 0){
                nums[i + 1] ^= 1;
                nums[i + 2] ^= 1;
                operations++;
            }
        }

        return nums[nums.Length - 1] == 1 && nums[nums.Length - 2] == 1 ? operations : -1;
    }
}