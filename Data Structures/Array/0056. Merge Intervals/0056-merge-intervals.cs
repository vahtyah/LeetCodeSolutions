namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 0056. Merge Intervals
 * Difficulty: Medium
 * Submission Time: 2025-02-20 17:28:28
 * Created by vahtyah on 2025-02-20 17:28:43
*/
 
public class Solution {
    public int[][] Merge(int[][] intervals) {
        if (intervals.Length <= 1) return intervals;
        Array.Sort(intervals, CompareIntervals);

        var result = new List<int[]>(intervals.Length);
        for(int i = 0; i < intervals.Length; i++){
            var start = i;
            var end = i;
            while(i < intervals.Length - 1 && intervals[end][1] >= intervals[i + 1][0]){
                i++;
                if(intervals[i][1] > intervals[end][1]) end = i;
            }

            result.Add(new int[]{intervals[start][0], intervals[end][1]});
        }

        return result.ToArray();
    }

    private static int CompareIntervals(int[] a, int[] b) {
        return a[0].CompareTo(b[0]);
    }
}