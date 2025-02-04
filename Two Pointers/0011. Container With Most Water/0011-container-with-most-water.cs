namespace LeetCodeSolutions.TwoPointers;

/*
 * 0011. Container With Most Water
 * Difficulty: Medium
 * Submission Time: 2025-02-04 17:13:52
 * Created by vahtyah on 2025-02-04 17:14:19
 */
 
public class Solution {
    public int MaxArea(int[] height) {
        if (height == null || height.Length < 2) return 0;
        
        int left = 0;
        int right = height.Length - 1;
        int maxArea = 0;
        
        while (left < right) {
            int leftHeight = height[left];
            int rightHeight = height[right];
            int width = right - left;
            int currentArea = width * (leftHeight < rightHeight ? leftHeight : rightHeight);
            if (currentArea > maxArea) maxArea = currentArea;
            
            if (leftHeight <= rightHeight) {
                while (left < right && height[left] <= leftHeight) left++;
            } else {
                while (left < right && height[right] <= rightHeight) right--;
            }
        }
        
        return maxArea;
    }
}