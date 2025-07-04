namespace LeetCodeSolutions.Math;

/*
 * 0066. Plus One
 * Difficulty: Easy
 * Submission Time: 2025-07-04 08:19:16
 * Created by vahtyah on 2025-07-04 08:19:35
*/
 
public class Solution {
    public int[] PlusOne(int[] digits) {
        var carry = 1;

        for(int i = digits.Length - 1; i >= 0; i--){
            var sum = digits[i] + carry;
            digits[i] = sum % 10;
            carry = sum / 10;
            if(carry == 0) return digits;
        }

        var result = new int[digits.Length + 1];
        result[0] = 1;

        return result;
    }
}