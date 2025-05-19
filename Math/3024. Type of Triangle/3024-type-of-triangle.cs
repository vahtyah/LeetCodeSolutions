namespace LeetCodeSolutions.Math;

/*
 * 3024. Type of Triangle
 * Difficulty: Easy
 * Submission Time: 2025-05-19 05:58:12
 * Created by vahtyah on 2025-05-19 05:58:38
*/
 
public class Solution {
    public string TriangleType(int[] nums) {
        if(nums[0] + nums[1] <= nums[2] || nums[1] + nums[2] <= nums[0] || nums[0] + nums[2] <= nums[1]) return "none";
        if(nums[0] == nums[1] && nums[1] == nums[2]) return "equilateral";
        if(nums[0] == nums[1] || nums[1] == nums[2] || nums[0] == nums[2]) return "isosceles";
        return "scalene";
    }
}