namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 1304. Find N Unique Integers Sum up to Zero
 * Difficulty: Easy
 * Submission Time: 2025-09-07 08:07:00
 * Created by vahtyah on 2025-09-07 08:16:53
*/
 
public class Solution {
    public int[] SumZero(int n) {
        var result = new int[n];
        var len = n;

        for(int i = 0; i < len / 2; i++){
            result[i] = -1 * n;
            result[len - i - 1] = n;
            n--;
        }

        return result;
    }
}