namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 1437. Check If All 1's Are at Least Length K Places Away
 * Difficulty: Easy
 * Submission Time: 2025-11-17 05:25:58
 * Created by vahtyah on 2025-11-17 15:06:43
*/
 
public class Solution {
    public bool KLengthApart(int[] nums, int k) {
        var spaceSoFar = k;

        for(int i = 0; i < nums.Length; i++){
            if(nums[i] == 1){
                if(spaceSoFar < k) return false;
                spaceSoFar = 0;
            }
            else spaceSoFar++;
        }

        return true;
    }
}