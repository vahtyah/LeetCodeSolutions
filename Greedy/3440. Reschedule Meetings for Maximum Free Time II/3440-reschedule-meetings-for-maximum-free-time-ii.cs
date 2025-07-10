namespace LeetCodeSolutions.Greedy;

/*
 * 3440. Reschedule Meetings for Maximum Free Time II
 * Difficulty: Medium
 * Submission Time: 2025-07-10 09:22:34
 * Created by vahtyah on 2025-07-10 09:24:24
*/
 
public class Solution {
    public int MaxFreeTime(int eventTime, int[] startTime, int[] endTime) {
        int n = startTime.Length;
        
        Span<int> freeTime = stackalloc int[n + 1];
        freeTime[0] = startTime[0];
        for (int i = 1; i < n; i++) {
            freeTime[i] = startTime[i] - endTime[i - 1];
        }
        freeTime[n] = eventTime - endTime[n - 1];

        int maxFreeTime = 0;
        
        Span<int> prefixMax = stackalloc int[n + 1];
        Span<int> suffixMax = stackalloc int[n + 1];
        
        prefixMax[0] = freeTime[0];
        for (int i = 1; i <= n; i++) {
            prefixMax[i] = Math.Max(prefixMax[i - 1], freeTime[i]);
        }
        
        suffixMax[n] = freeTime[n];
        for (int i = n - 1; i >= 0; i--) {
            suffixMax[i] = Math.Max(suffixMax[i + 1], freeTime[i]);
        }

        for (int i = 0; i < n; i++) {
            int eventLength = endTime[i] - startTime[i];
            bool canMove = false;
            
            if (i > 0 && prefixMax[i - 1] >= eventLength) {
                canMove = true;
            }
            
            if (!canMove && i < n - 1 && suffixMax[i + 2] >= eventLength) {
                canMove = true;
            }
            
            if (canMove) {
                int start = (i == 0) ? 0 : endTime[i - 1];
                int end = (i == n - 1) ? eventTime : startTime[i + 1];
                maxFreeTime = Math.Max(maxFreeTime, end - start);
            } else {
                int combinedFreeTime = freeTime[i] + freeTime[i + 1];
                maxFreeTime = Math.Max(maxFreeTime, combinedFreeTime);
            }
        }

        return maxFreeTime;
    }
}