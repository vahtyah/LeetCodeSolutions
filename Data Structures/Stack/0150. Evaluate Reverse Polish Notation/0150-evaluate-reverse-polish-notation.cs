namespace LeetCodeSolutions.DataStructures/Stack;

/*
 * 0150. Evaluate Reverse Polish Notation
 * Difficulty: Medium
 * Submission Time: 2025-02-21 13:36:19
 * Created by vahtyah on 2025-02-21 13:36:40
*/
 
public class Solution {
    public int EvalRPN(string[] tokens) {
        Span<int> stack = stackalloc int[tokens.Length / 2 + 1];
        var top = -1;
        
        foreach (var token in tokens) {
            if (token.Length == 1 && !char.IsDigit(token[0])) {
                var b = stack[top--];
                var a = stack[top];
                
                stack[top] = token[0] switch {
                    '+' => a + b,
                    '-' => a - b,
                    '*' => a * b,
                    '/' => a / b,
                    _ => throw new ArgumentException("Invalid operator")
                };
            }
            else {
                stack[++top] = ParseInt(token);
            }
        }
        
        return stack[top];
    }

    private int ParseInt(string s){
        bool isNegative = s[0] == '-';
        int i = isNegative ? 1 : 0;
        int result = 0;

        for (; i < s.Length; i++) {
            result = (result * 10) + (s[i] - '0');
        }
        return isNegative ? -result : result;
    }
}