namespace LeetCodeSolutions.BitManipulation;

/*
 * 0201. Bitwise AND of Numbers Range
 * Difficulty: Medium
 * Submission Time: 2025-07-02 07:56:03
 * Created by vahtyah on 2025-07-02 07:56:24
*/
 
public class Solution {
    public int RangeBitwiseAnd(int left, int right) {
        if(left == right) return left;
        return left & ~((1 << (int.Log2(left ^ right) + 1)) - 1);
    }
}