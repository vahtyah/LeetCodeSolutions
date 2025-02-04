namespace LeetCodeSolutions.TwoPointers;

/*
 * 0125. Valid Palindrome
 * Difficulty: Easy
 * Submission Time: 2025-02-04 15:57:02
 * Created by vahtyah on 2025-02-04 15:57:37
 */
 
public class Solution {
    public bool IsPalindrome(string s) {
        if (string.IsNullOrEmpty(s)) return true;
        
        ReadOnlySpan<char> span = s.AsSpan();
        int left = 0;
        int right = span.Length - 1;
        
        while (left < right) {
            char leftChar = GetNextValidChar(span, ref left, right, true);
            char rightChar = GetNextValidChar(span, ref right, left, false);
            
            if (left >= right) return true;
            
            if (char.ToLowerInvariant(leftChar) != char.ToLowerInvariant(rightChar)) {
                return false;
            }
            
            left++;
            right--;
        }
        
        return true;
    }
    
    private static char GetNextValidChar(ReadOnlySpan<char> span, ref int index, int boundary, bool movingForward) {
        while (movingForward ? index < boundary : index > boundary) {
            char c = span[index];
            if (IsAlphanumeric(c)) {
                return c;
            }
            index += movingForward ? 1 : -1;
        }
        return '\0';
    }
    
    private static bool IsAlphanumeric(char c) {
        return (c >= '0' && c <= '9') || 
               (c >= 'a' && c <= 'z') || 
               (c >= 'A' && c <= 'Z');
    }
}