namespace LeetCodeSolutions.Math;

/*
 * 2579. Count Total Number of Colored Cells
 * Difficulty: Medium
 * Submission Time: 2025-03-05 04:32:13
 * Created by vahtyah on 2025-03-05 04:33:24
*/
 
public class Solution {
    public long ColoredCells(int n) {
        return 2L * n * (n - 1) + 1;
    }
}