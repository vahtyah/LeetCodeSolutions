namespace LeetCodeSolutions.Recursion/Backtracking;

/*
 * 0022. Generate Parentheses
 * Difficulty: Medium
 * Submission Time: 2025-06-07 07:09:49
 * Created by vahtyah on 2025-06-07 07:10:08
*/
 
public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        var result = new List<string>();
        var current = new char[2 * n];
        Backtrack(n, 0, 0, 0, result, current);
        return result;
    }

    private void Backtrack(int n, int open, int close, int index, IList<string> result, char[] current) {
        if (index == 2 * n) {
            result.Add(new string(current));
            return;
        }
        
        if (open < n) {
            current[index] = '(';
            Backtrack(n, open + 1, close, index + 1, result, current);
        }
        
        if (close < open) {
            current[index] = ')';
            Backtrack(n, open, close + 1, index + 1, result, current);
        }
    }
}