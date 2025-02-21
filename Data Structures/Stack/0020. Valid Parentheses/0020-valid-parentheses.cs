namespace LeetCodeSolutions.DataStructures/Stack;

/*
 * 0020. Valid Parentheses
 * Difficulty: Easy
 * Submission Time: 2025-02-21 11:36:16
 * Created by vahtyah on 2025-02-21 11:36:52
*/
 
public class Solution {
    public bool IsValid(string s) {
        if (s.Length % 2 != 0) return false;
        
        char[] stack = new char[s.Length];
        int top = -1;
        
        for (int i = 0; i < s.Length; i++) {
            char c = s[i];
            
            if (c == '(' || c == '{' || c == '[') {
                stack[++top] = c;
            }
            else {
                if (top == -1 || !IsMatchingPair(stack[top], c)) {
                    return false;
                }
                top--;
            }
        }
        
        return top == -1;
    }
    
    private bool IsMatchingPair(char open, char close) => (open, close) switch {
        ('(', ')') => true,
        ('{', '}') => true,
        ('[', ']') => true,
        _ => false
    };
}