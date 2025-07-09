namespace LeetCodeSolutions.SlidingWindow;

/*
 * 3439. Reschedule Meetings for Maximum Free Time I
 * Difficulty: Medium
 * Submission Time: 2025-07-09 18:08:44
 * Created by vahtyah on 2025-07-09 18:11:22
*/
 
public class Solution {
    public int MaxFreeTime(int eventTime, int k, int[] startTime, int[] endTime) {
        int n = startTime.Length;
        
        int[] sum = new int[n + 1];
        for (int i = 0; i < n; i++) {
            sum[i + 1] = sum[i] + (endTime[i] - startTime[i]);
        }
        
        int maxFreeTime = 0;
        
        for (int i = k - 1; i < n; i++) {
            int right = (i == n - 1) ? eventTime : startTime[i + 1];
            int left = (i == k - 1) ? 0 : endTime[i - k];
            
            int freeTime = right - left - (sum[i + 1] - sum[i - k + 1]);
            
            maxFreeTime = Math.Max(maxFreeTime, freeTime);
        }
        
        return maxFreeTime;
    }
}