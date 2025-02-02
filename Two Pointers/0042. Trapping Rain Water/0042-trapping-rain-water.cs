namespace LeetCodeSolutions.TwoPointers;

/*
 * 0042. Trapping Rain Water
 * Difficulty: Hard
 * Submission Time: 2025-02-02 16:23:07
 * Created by vahtyah on 2025-02-02 16:23:41
 */
 
public class Solution {
    public int Trap(int[] height) {
        if (height.Length < 3)
            return 0;
            
        int left = 0;
        int right = height.Length - 1;
        int leftMax = 0;
        int rightMax = 0;
        int totalWater = 0;
        
        while (left < right) {
            leftMax = Math.Max(leftMax, height[left]);
            rightMax = Math.Max(rightMax, height[right]);
            
            if (leftMax < rightMax) {
                totalWater += leftMax - height[left];
                left++;
            }
            else {
                totalWater += rightMax - height[right];
                right--;
            }
        }
        
        return totalWater;
    }
}