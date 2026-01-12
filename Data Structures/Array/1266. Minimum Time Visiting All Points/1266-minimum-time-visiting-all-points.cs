namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 1266. Minimum Time Visiting All Points
 * Difficulty: Easy
 * Submission Time: 2026-01-12 13:01:29
 * Created by vahtyah on 2026-01-12 15:10:59
*/
 
public class Solution {
    public int MinTimeToVisitAllPoints(int[][] points) {
        var result = 0;

        for(int i = 1; i < points.Length; i++){
            result += Math.Max(Math.Abs(points[i][0] - points[i - 1][0]), Math.Abs(points[i][1] - points[i - 1][1]));
        }

        return result;
    }
}