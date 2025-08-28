namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 3446. Sort Matrix by Diagonals
 * Difficulty: Medium
 * Submission Time: 2025-08-28 13:17:37
 * Created by vahtyah on 2025-08-28 13:18:06
*/
 
public class Solution {
    public int[][] SortMatrix(int[][] grid) {
        var n = grid.Length;

        for(int i = 1; i < n; i++){
            var arr = new int[n - i];
            var row = 0;
            var col = i;

            for(int j = 0; j < n - i; j++){
                arr[j] = grid[row++][col++];
            }

            Array.Sort(arr);

            for(int j = 0; j < n - i; j++){
                grid[--row][--col] = arr[n - i - j - 1];
            }
        }

        for(int i = 0; i < n; i++){
            var arr = new int[n - i];
            var row = i;
            var col = 0;

            for(int j = 0; j < n - i; j++){
                arr[j] = grid[row++][col++];
            }

            Array.Sort(arr);

            for(int j = 0; j < n - i; j++){
                grid[--row][--col] = arr[j];
            }
        }

        return grid;
    }
}