namespace LeetCodeSolutions.BitManipulation;

/*
 * 0338. Counting Bits
 * Difficulty: Easy
 * Submission Time: 2025-01-15 19:40:49
 * Created by vahtyah on 2025-06-06 07:48:57
*/
 
public class Solution {
    public int[] CountBits(int n) {
        var answer = new int[n + 1];

        for(int i = 0; i <= n; i++){
            answer[i] = answer[i >> 1] + (i & 1);
        }

        return answer;
    }
}