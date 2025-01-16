public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        Array.Sort(intervals, (a, b) => a[1].CompareTo(b[1]));
        var count = 0;
        var lastEnd = int.MinValue;
        for(int i = 0; i < intervals.Length; i++){
            if(intervals[i][0] < lastEnd) count++;
            else lastEnd = intervals[i][1];
        }

        return count;
    }               
}