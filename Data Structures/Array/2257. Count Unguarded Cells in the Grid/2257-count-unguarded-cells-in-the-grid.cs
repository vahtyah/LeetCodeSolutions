namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 2257. Count Unguarded Cells in the Grid
 * Difficulty: Medium
 * Submission Time: 2025-11-02 05:53:31
 * Created by vahtyah on 2025-11-02 05:54:05
*/
 
public class Solution {
    public int CountUnguarded(int m, int n, int[][] guards, int[][] walls) {
        var grid = new int[m, n];

        for(int i = 0; i < guards.Length; i++){
            grid[guards[i][0], guards[i][1]] = 1;
        }

        for(int i = 0; i < walls.Length; i++){
            grid[walls[i][0], walls[i][1]] = 2;
        }

        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                if(grid[i, j] != 1) continue;

                for(int left = j - 1; left >= 0; left--){
                    if(grid[i, left] == 2 || grid[i, left] == 1) break;
                    grid[i, left] = 3;
                }

                for(int right = j + 1; right < n; right++){
                    if(grid[i, right] == 2 || grid[i, right] == 1) break;
                    grid[i, right] = 3;
                }

                for(int top = i - 1; top >= 0; top--){
                    if(grid[top, j] == 2 || grid[top, j] == 1) break;
                    grid[top, j] = 3;
                }

                for(int bot = i + 1; bot < m; bot++){
                    if(grid[bot, j] == 2 || grid[bot, j] == 1) break;
                    grid[bot, j] = 3;
                }
            }
        }

        var result = 0;

        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                if(grid[i, j] == 0) result++;        
            }
        }

        return result;
    }
}