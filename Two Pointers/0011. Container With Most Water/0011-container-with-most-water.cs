namespace LeetCodeSolutions.TwoPointers;

/*
 * 0011. Container With Most Water
 * Difficulty: Medium
 * Submission Time: 2025-10-04 07:45:24
 * Created by vahtyah on 2025-10-04 15:41:10
*/
 
public class Solution {
    public int MaxArea(int[] heights) {
        int left = 0, right = heights.Length - 1;
        var maxArea = 0;

        while(left < right){
            var height = Math.Min(heights[left], heights[right]);
            maxArea = Math.Max(height * (right - left), maxArea);
            if(heights[left] < heights[right]) left++;
            else right--;
        }

        return maxArea;
    }
}