namespace LeetCodeSolutions.Math;

/*
 * 0009. Palindrome Number
 * Difficulty: Easy
 * Submission Time: 2025-01-11 10:48:30
 * Created by vahtyah on 2025-03-04 04:23:03
*/
 
public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0 || (x != 0 && x % 10 == 0)) {
            return false;
        }
        
        int reversedHalf = 0;
        while (x > reversedHalf) {
            reversedHalf = reversedHalf * 10 + x % 10;
            x /= 10;
        }
        
        return x == reversedHalf || x == reversedHalf/10;
    }
}