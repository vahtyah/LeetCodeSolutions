namespace LeetCodeSolutions.BitManipulation;

/*
 * 0868. Binary Gap
 * Difficulty: Easy
 * Submission Time: 2026-02-22 15:39:19
 * Created by vahtyah on 2026-02-22 15:40:13
*/
 
public class Solution {
    public int BinaryGap(int n) {
        int maxGap = 0;
        int lastIndex = -1;
        int index = 0;

        while (n > 0) {
            if ((n & 1) == 1) {
                if (lastIndex != -1) {
                    maxGap = Math.Max(maxGap, index - lastIndex);
                }
                lastIndex = index;
            }

            index++;
            n >>= 1;
        }

        return maxGap;
    }
}