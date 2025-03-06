namespace LeetCodeSolutions.DataStructures/HashTable;

/*
 * 2965. Find Missing and Repeated Values
 * Difficulty: Easy
 * Submission Time: 2025-03-06 05:20:04
 * Created by vahtyah on 2025-03-06 05:21:13
*/
 
public class Solution {
    public int[] FindMissingAndRepeatedValues(int[][] grid) {
        int n = grid.Length;
        int totalElements = n * n;
        
        bool[] seen = new bool[totalElements + 1];
        
        int repeated = 0;
        long actualSum = 0;
        
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                int current = grid[i][j];
                
                if (seen[current]) {
                    repeated = current;
                } else {
                    seen[current] = true;
                    actualSum += current;
                }
            }
        }
        
        long expectedSum = (long)totalElements * (totalElements + 1) / 2;
        int missing = (int)(expectedSum - actualSum);
        
        return new int[] { repeated, missing };
    }
}