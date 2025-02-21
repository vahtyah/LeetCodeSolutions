namespace LeetCodeSolutions.Searching/BinarySearch;

/*
 * 0057. Insert Interval
 * Difficulty: Medium
 * Submission Time: 2025-02-21 07:00:02
 * Created by vahtyah on 2025-02-21 07:09:55
*/
 
public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        int n = intervals.Length;
        if (n == 0) 
            return new int[][] { newInterval };

        // Binary search: Find the first interval whose end is not less than newInterval[0]
        int left = 0, lo = 0, hi = n;
        while (lo < hi) {
            int mid = lo + (hi - lo) / 2;
            if (intervals[mid][1] < newInterval[0])
                lo = mid + 1;
            else
                hi = mid;
        }
        left = lo;

        // Binary search: Find the first interval whose start is greater than newInterval[1]
        lo = left; hi = n;
        while (lo < hi) {
            int mid = lo + (hi - lo) / 2;
            if (intervals[mid][0] <= newInterval[1])
                lo = mid + 1;
            else
                hi = mid;
        }
        int right = lo;

        if (left < right) {
            newInterval[0] = Math.Min(newInterval[0], intervals[left][0]);
            newInterval[1] = Math.Max(newInterval[1], intervals[right - 1][1]);
        }
        
        List<int[]> result = new List<int[]>(n + 1);
        
        for (int i = 0; i < left; i++) {
            result.Add(intervals[i]);
        }
        
        result.Add(newInterval);
        
        for (int i = right; i < n; i++) {
            result.Add(intervals[i]);
        }
        
        return result.ToArray();
    }
}
