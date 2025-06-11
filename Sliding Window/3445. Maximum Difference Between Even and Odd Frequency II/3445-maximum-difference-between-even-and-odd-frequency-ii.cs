namespace LeetCodeSolutions.SlidingWindow;

/*
 * 3445. Maximum Difference Between Even and Odd Frequency II
 * Difficulty: Hard
 * Submission Time: 2025-06-11 06:03:24
 * Created by vahtyah on 2025-06-11 06:04:08
*/
 
public class Solution {
    public int MaxDifference(string s, int k) {
        int n = s.Length;
        int ans = int.MinValue;
        
        ReadOnlySpan<char> span = s.AsSpan();
        
        int[] best = new int[4];
        
        for (char a = '0'; a <= '4'; a++) {
            for (char b = '0'; b <= '4'; b++) {
                if (a == b) continue;
                
                Array.Fill(best, int.MaxValue);
                
                int cntA = 0, cntB = 0;
                int prevA = 0, prevB = 0;
                int left = -1;
                
                for (int right = 0; right < n; right++) {
                    char ch = span[right];
                    
                    cntA += (ch == a) ? 1 : 0;
                    cntB += (ch == b) ? 1 : 0;
                    
                    while (right - left >= k && cntB - prevB >= 2) {
                        int leftStatus = GetStatus(prevA, prevB);
                        int diff = prevA - prevB;
                        
                        if (diff < best[leftStatus]) {
                            best[leftStatus] = diff;
                        }
                        
                        left++;
                        char leftCh = span[left];
                        prevA += (leftCh == a) ? 1 : 0;
                        prevB += (leftCh == b) ? 1 : 0;
                    }
                    
                    int rightStatus = GetStatus(cntA, cntB);
                    int targetStatus = rightStatus ^ 0b10;
                    
                    if (best[targetStatus] != int.MaxValue) {
                        int currentDiff = (cntA - cntB) - best[targetStatus];
                        if (currentDiff > ans) {
                            ans = currentDiff;
                        }
                    }
                }
            }
        }
        
        return ans;
    }
    
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    private static int GetStatus(int cntA, int cntB) {
        return ((cntA & 1) << 1) | (cntB & 1);
    }
}