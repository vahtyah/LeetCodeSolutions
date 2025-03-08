namespace LeetCodeSolutions.SlidingWindow;

/*
 * 2379. Minimum Recolors to Get K Consecutive Black Blocks
 * Difficulty: Easy
 * Submission Time: 2025-03-08 05:20:15
 * Created by vahtyah on 2025-03-08 05:20:35
*/
 
public class Solution {
    public int MinimumRecolors(string blocks, int k) {
        var whiteCount = 0;
        for (int i = 0; i < k; i++) {
            if (blocks[i] == 'W') {
                whiteCount++;
            }
        }
        
        var minOperations = whiteCount;
        for (int i = k; i < blocks.Length; i++) {
            if (blocks[i] == 'W') whiteCount++;
            if (blocks[i - k] == 'W') whiteCount--;
            minOperations = Math.Min(minOperations, whiteCount);
        }
        
        return minOperations;
    }
}