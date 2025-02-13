namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 0054. Spiral Matrix
 * Difficulty: Medium
 * Submission Time: 2025-02-13 06:31:32
 * Created by vahtyah on 2025-02-13 06:31:55
*/
 
public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        if (matrix == null || matrix.Length == 0) return new List<int>();
        
        var result = new List<int>();
        var top = 0;
        var bottom = matrix.Length - 1;
        var left = 0;
        var right = matrix[0].Length - 1;
        
        while (top <= bottom && left <= right) {
            for (int i = left; i <= right; i++) {
                result.Add(matrix[top][i]);
            }
            top++;
            
            for (int i = top; i <= bottom; i++) {
                result.Add(matrix[i][right]);
            }
            right--;
            
            if (top <= bottom) {
                for (int i = right; i >= left; i--) {
                    result.Add(matrix[bottom][i]);
                }
                bottom--;
            }
            
            if (left <= right) {
                for (int i = bottom; i >= top; i--) {
                    result.Add(matrix[i][left]);
                }
                left++;
            }
        }
        
        return result;
    }
}