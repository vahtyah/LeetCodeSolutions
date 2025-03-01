namespace LeetCodeSolutions.Recursion/NonTailRecursion;

/*
 * 0224. Basic Calculator
 * Difficulty: Hard
 * Submission Time: 2025-02-22 10:23:15
 * Created by vahtyah on 2025-03-01 07:49:09
*/
 
public class Solution {
    public int Calculate(string s) {
        int i = 0;
        return CalculateHelper(s.AsSpan(), ref i);
    }
    
    private int CalculateHelper(ReadOnlySpan<char> s, ref int i) {
        Span<int> stack = stackalloc int[2]; 
        stack[0] = 0; 
        stack[1] = 1; 
        
        for (; i < s.Length; i++) {
            char c = s[i];
            
            if (c is >= '0' and <= '9') {
                int num = c - '0';
                while (i + 1 < s.Length && s[i + 1] is >= '0' and <= '9') {
                    num = num * 10 + (s[++i] - '0');
                }
                stack[0] += stack[1] * num;
            }
            else {
                switch (c) {
                    case '+':
                        stack[1] = 1;
                        break;
                    case '-':
                        stack[1] = -1;
                        break;
                    case '(':
                        i++; 
                        stack[0] += stack[1] * CalculateHelper(s, ref i);
                        stack[1] = 1; 
                        break;
                    case ')':
                        return stack[0];
                }
            }
        }
        
        return stack[0];
    }
}