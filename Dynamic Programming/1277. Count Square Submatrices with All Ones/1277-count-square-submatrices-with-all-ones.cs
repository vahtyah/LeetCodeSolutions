namespace LeetCodeSolutions.DynamicProgramming;

/*
 * 1277. Count Square Submatrices with All Ones
 * Difficulty: Medium
 * Submission Time: 2025-08-20 13:54:07
 * Created by vahtyah on 2025-08-20 13:54:31
*/
 
public class Solution {
    public int CountSquares(int[][] matrix) {
        var m = matrix.Length;
        var n = matrix[0].Length;

        var count = 0;

        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                if(matrix[i][j] != 1) continue;
                if(i != 0 && j != 0) matrix[i][j] = Math.Min(matrix[i - 1][j - 1], Math.Min(matrix[i - 1][j], matrix[i][j - 1])) + 1;
                count += matrix[i][j];
            }
        }

        return count;
    }
}