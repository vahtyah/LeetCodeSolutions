namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 0840. Magic Squares In Grid
 * Difficulty: Medium
 * Submission Time: 2025-12-30 07:08:23
 * Created by vahtyah on 2025-12-30 15:01:24
*/
 
public class Solution {
    public int NumMagicSquaresInside(int[][] grid) {
        var n = grid.Length;
        var m = grid[0].Length;

        var result = 0;

        for(int i = 0; i < n - 2; i++){
            for(int j = 0; j < m - 2; j++){
                if(CanBeAMagicSquare(i, j, grid)) result++;
            }
        }
        
        return result;
    }

    private bool CanBeAMagicSquare(int i, int j, int[][] g)
    {
        if (g[i + 1][j + 1] != 5)
            return false;

        int a = g[i][j];
        int b = g[i][j + 1];
        int c = g[i][j + 2];
        int d = g[i + 1][j];
        int f = g[i + 1][j + 2];
        int g1 = g[i + 2][j];
        int h = g[i + 2][j + 1];
        int k = g[i + 2][j + 2];

        int mask =
            (1 << a) | (1 << b) | (1 << c) |
            (1 << d) | (1 << 5) | (1 << f) |
            (1 << g1) | (1 << h) | (1 << k);

        // Bits 1..9 must be set exactly once => mask == 0b1111111110 (1022)
        if (mask != 1022)
            return false;

            // Rows
        return a + b + c == 15 &&
            d + 5 + f == 15 &&
            g1 + h + k == 15 &&

            // Columns
            a + d + g1 == 15 &&
            b + 5 + h == 15 &&
            c + f + k == 15 &&

            // Diagonals
            a + 5 + k == 15 &&
            c + 5 + g1 == 15;
    }

}