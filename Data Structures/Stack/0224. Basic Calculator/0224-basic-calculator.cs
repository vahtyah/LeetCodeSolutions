namespace LeetCodeSolutions.DataStructures/Stack;

/*
 * 0224. Basic Calculator
 * Difficulty: Hard
 * Submission Time: 2025-02-22 09:44:18
 * Created by vahtyah on 2025-02-22 09:46:33
*/
 
public class Solution {
    public int Calculate(string s) {
        Span<int> stack = stackalloc int[s.Length]; 
        int stackIndex = 0;
        int result = 0;
        int sign = 1;
        int currNum = 0;
        int len = s.Length;
        
        for (int i = 0; i < len; i++) {
            char c = s[i];
            
            if (c >= '0') { 
                currNum = currNum * 10 + (c - '0');
                
                while (i + 1 < len && s[i + 1] >= '0' && s[i + 1] <= '9') {
                    currNum = currNum * 10 + (s[++i] - '0');
                }
            }
            else if (c == '+' || c == '-') {
                result += sign * currNum;
                currNum = 0;
                sign = 44 - c; // '+' ASCII is 43, '-' ASCII is 45, so 44-'+' = 1, 44-'-' = -1
            }
            else if (c == '(') {
                stack[stackIndex++] = result;
                stack[stackIndex++] = sign;
                result = 0;
                sign = 1;
            }
            else if (c == ')') {
                result += sign * currNum;
                currNum = 0;
                result *= stack[--stackIndex]; // Get sign
                result += stack[--stackIndex]; // Get previous result
            }
        }
        
        if (currNum != 0 || result == 0) {
            result += sign * currNum;
        }
        
        return result;
    }
}