namespace LeetCodeSolutions.DynamicProgramming;

/*
 * 0118. Pascal's Triangle
 * Difficulty: Easy
 * Submission Time: 2025-07-08 21:30:24
 * Created by vahtyah on 2025-07-08 21:30:45
*/
 
public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        var result = new int[numRows][];
        for(int i = 0; i < numRows; i++){
            result[i] = new int[i + 1];
            result[i][0] = result[i][i] = 1;
        }

        for(int i = 2; i < numRows; i++){
            for(int j = 1; j < result[i].Length - 1; j++){
                result[i][j] = result[i - 1][j - 1] + result[i - 1][j];
            }
        }

        return result;
    }
}