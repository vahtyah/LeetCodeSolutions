namespace LeetCodeSolutions.Searching/BinarySearch;

/*
 * 0074. Search a 2D Matrix
 * Difficulty: Medium
 * Submission Time: 2025-06-12 06:46:53
 * Created by vahtyah on 2025-06-12 06:47:28
*/
 
public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        var m = matrix.Length;
        var n = matrix[0].Length;
        var left = 0;
        var right = m * n - 1;
        
        while (left <= right) {
            var mid = left + (right - left) / 2;
            var midValue = matrix[mid / n][mid % n];
            
            if (midValue == target) return true;
            else if (midValue < target) left = mid + 1;
            else right = mid - 1;
        }
        
        return false;
    }
}