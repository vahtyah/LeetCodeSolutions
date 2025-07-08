namespace LeetCodeSolutions.DynamicProgramming;

/*
 * 0119. Pascal's Triangle II
 * Difficulty: Easy
 * Submission Time: 2025-07-08 21:38:59
 * Created by vahtyah on 2025-07-08 21:39:39
*/
 
public class Solution {
    private static int[][] rows;

    public Solution(){
        if(rows != null) return;
        
        rows = new int[34][];

        for(int i = 0; i < 34; i++){
            rows[i] = new int[i + 1];
            rows[i][0] = rows[i][i] = 1;
        }

        for(int i = 2; i < 34; i++){
            for(int j = 1; j < rows[i].Length - 1; j++){
                rows[i][j] = rows[i - 1][j - 1] + rows[i - 1][j];
            }
        }
    }

    public IList<int> GetRow(int rowIndex) {
        return rows[rowIndex];
    }
}