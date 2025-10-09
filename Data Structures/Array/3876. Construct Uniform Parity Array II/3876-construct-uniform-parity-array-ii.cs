namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 3876. Construct Uniform Parity Array II
 * Difficulty: Medium
 * Submission Time: 2026-09-03 08:13:04
 * Created by vahtyah on 2026-09-04 09:52:25
*/
 
public class Solution {
    public bool UniformArray(int[] nums) {
        var n = nums.Length;
        var min = nums[0];
        var hasOdd = false;
        
        for(int i = 0; i < n; i++){
            if(min > nums[i]) min = nums[i];
            if((nums[i] & 1) == 1) hasOdd = true;
        }

        if ((min & 1) == 1) return true;
        return !hasOdd;
    }
}