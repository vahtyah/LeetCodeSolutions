namespace LeetCodeSolutions.Math;

/*
 * 3516. Find Closest Person
 * Difficulty: Easy
 * Submission Time: 2025-09-04 12:39:37
 * Created by vahtyah on 2025-09-04 12:40:20
*/
 
public class Solution {
    public int FindClosest(int x, int y, int z) {
        var step1 = Math.Abs(x - z);
        var step2 = Math.Abs(y - z);

        return step1 < step2 ? 1 : step1 == step2 ? 0 : 2;
    }
}