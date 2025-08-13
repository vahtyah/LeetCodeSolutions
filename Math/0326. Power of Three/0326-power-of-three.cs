namespace LeetCodeSolutions.Math;

/*
 * 0326. Power of Three
 * Difficulty: Easy
 * Submission Time: 2025-08-13 13:27:17
 * Created by vahtyah on 2025-08-13 13:28:01
*/
 
public class Solution {
    public bool IsPowerOfThree(int n) {
        // 3^19 = 1162261467 is the largest power of 3 fits within the signed 32bit interger
        return n > 0 && 1162261467 % n == 0;
    }
}