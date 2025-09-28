namespace LeetCodeSolutions.Math;

/*
 * 0976. Largest Perimeter Triangle
 * Difficulty: Easy
 * Submission Time: 2025-09-28 02:38:11
 * Created by vahtyah on 2025-09-28 02:39:04
*/
 
public class Solution {
    public int LargestPerimeter(int[] nums) {
        Array.Sort(nums);

        for(int i = nums.Length - 1; i >= 2; i--){
            if(nums[i] < nums[i - 1] + nums[i - 2]) return nums[i] + nums[i - 1] + nums[i - 2];            
        }

        return 0;
    }
}