namespace LeetCodeSolutions.TwoPointers;

/*
 * 0167. Two Sum II - Input Array Is Sorted
 * Difficulty: Medium
 * Submission Time: 2025-02-04 16:43:47
 * Created by vahtyah on 2025-02-04 16:44:41
 */
 
public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left = 0;
        int right = numbers.Length - 1;
        
        while (left < right) {
            int sum = numbers[left] + numbers[right];
            
            if (sum == target) {
                return new int[] { left + 1, right + 1 };
            } 
            else if (sum < target) {
                left++;
            }
            else {
                right--;
            }
        }
        
        return new int[] { -1, -1 };
    }
}