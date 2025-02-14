namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 0048. Rotate Image
 * Difficulty: Medium
 * Submission Time: 2025-02-14 17:09:26
 * Created by vahtyah on 2025-02-14 17:09:46
*/
 
public class Solution {
    public void Rotate(int[][] matrix) {
        int n = matrix.Length;
        
        // Step 1: Transpose the matrix (swap elements across main diagonal)
        for (int i = 0; i < n; i++) {
            for (int j = i + 1; j < n; j++) {
                int temp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp;
            }
        }
        
        // Step 2: Reverse each row
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n/2; j++) {
                int temp = matrix[i][j];
                matrix[i][j] = matrix[i][n - 1 - j];
                matrix[i][n - 1 - j] = temp;
            }
        }
    }
}