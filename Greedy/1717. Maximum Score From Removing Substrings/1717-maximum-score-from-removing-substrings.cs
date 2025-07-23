namespace LeetCodeSolutions.Greedy;

/*
 * 1717. Maximum Score From Removing Substrings
 * Difficulty: Medium
 * Submission Time: 2025-07-23 12:30:17
 * Created by vahtyah on 2025-07-23 12:31:35
*/
 
public class Solution {
    public int MaximumGain(string s, int x, int y) {
        int totalScore = 0;
        int aCount = 0, bCount = 0;
        int minPoints = Math.Min(x, y);
        int maxPoints = Math.Max(x, y);
        
        foreach (char c in s) {
            if (c == 'a') {
                if (y > x && bCount > 0) {
                    bCount--;
                    totalScore += y;
                } else {
                    aCount++;
                }
            } else if (c == 'b') {
                if (x > y && aCount > 0) {
                    aCount--;
                    totalScore += x;
                } else {
                    bCount++;
                }
            } else {
                totalScore += Math.Min(aCount, bCount) * minPoints;
                aCount = bCount = 0;
            }
        }
        
        totalScore += Math.Min(aCount, bCount) * minPoints;
        
        return totalScore;
    }
}