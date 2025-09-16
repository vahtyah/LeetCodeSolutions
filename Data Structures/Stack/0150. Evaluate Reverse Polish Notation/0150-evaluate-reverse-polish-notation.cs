namespace LeetCodeSolutions.DataStructures/Stack;

/*
 * 0150. Evaluate Reverse Polish Notation
 * Difficulty: Medium
 * Submission Time: 2026-06-14 14:54:40
 * Created by vahtyah on 2026-06-14 14:55:41
*/
 
public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        var n = tokens.Length;
        Span<int> stack = stackalloc int[n];
        var top = -1;

        for (int i = 0; i < n; i++)
        {
            var token = tokens[i];
            if (TryParse(token, out int number))
            {
                stack[++top] = number;
                continue;
            }

            var value = stack[top--];

            switch (token)
            {
                case "+":
                    stack[top] += value;
                    break;
                case "-":
                    stack[top] -= value;
                    break;
                case "*":
                    stack[top] *= value;
                    break;
                default:
                    stack[top] /= value;
                    break;
            }
        }

        return stack[0];
    }

    private static bool TryParse(string s, out int value)
    {
        if ((uint)(s[0] - '0') <= 9)
        {
            value = s[0] - '0';

            for (int i = 1; i < s.Length; i++)
                value = value * 10 + (s[i] - '0');

            return true;
        }

        if (s.Length > 1 && s[0] == '-')
        {
            value = 0;

            for (int i = 1; i < s.Length; i++)
                value = value * 10 + (s[i] - '0');

            value = -value;
            return true;
        }

        value = 0;
        return false;
    }
}