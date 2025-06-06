namespace LeetCodeSolutions.BitManipulation;

/*
 * 3151. Special Array I
 * Difficulty: Easy
 * Submission Time: 2025-02-01 11:58:53
 * Created by vahtyah on 2025-06-06 07:47:25
*/
 
public class Solution {
    public bool IsArraySpecial(int[] nums) {
        if (nums.Length <= 1) return true;
        
        for(var i = 1; i < nums.Length; i++){
            if(((nums[i] ^ nums[i-1]) & 1) == 0) return false;
        }
        
        return true;
    }
}