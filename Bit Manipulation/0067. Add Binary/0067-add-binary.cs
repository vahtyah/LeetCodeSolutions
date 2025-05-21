namespace LeetCodeSolutions.BitManipulation;

/*
 * 0067. Add Binary
 * Difficulty: Easy
 * Submission Time: 2025-05-21 06:18:32
 * Created by vahtyah on 2025-05-21 06:18:55
*/
 
public class Solution {
    public string AddBinary(string a, string b) {
        int aLen = a.Length - 1;
        int bLen = b.Length - 1;
        int maxLen = Math.Max(a.Length, b.Length);
        
        char[] ans = new char[maxLen + 1];
        int carry = 0;
        int resultIndex = maxLen;
        
        while (aLen >= 0 || bLen >= 0 || carry > 0) {
            int aVal = aLen >= 0 ? a[aLen--] - '0' : 0;
            int bVal = bLen >= 0 ? b[bLen--] - '0' : 0;
            int sum = carry + aVal + bVal;
            
            ans[resultIndex--] = (char)((sum % 2) + '0');
            carry = sum / 2;
        }
        
        return new string(ans, resultIndex + 1, ans.Length - resultIndex - 1);
    }
}