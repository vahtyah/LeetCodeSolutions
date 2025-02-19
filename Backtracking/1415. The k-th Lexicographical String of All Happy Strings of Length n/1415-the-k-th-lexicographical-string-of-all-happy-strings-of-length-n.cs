namespace LeetCodeSolutions.Backtracking;

/*
 * 1415. The k-th Lexicographical String of All Happy Strings of Length n
 * Difficulty: Medium
 * Submission Time: 2025-02-19 06:24:18
 * Created by vahtyah on 2025-02-19 06:27:24
*/
 
public class Solution {
    public string GetHappyString(int n, int k) {
        int maxPossible = 3 * (1 << (n - 1));
        if (k > maxPossible) return "";
        var sb = new StringBuilder(n);
        Backtracking(n, k, sb);
        return sb.ToString();
    }

    public int Backtracking(int n, int k, StringBuilder current){
        if (current.Length == n) {
            k--;
            return k;
        }

        var remainingPossible = (current.Length == 0 ? 3 : 2) * (current.Length < n - 1 ? (1 << (n - current.Length - 1)) : 1);
        if (k > remainingPossible) {
            k -= remainingPossible;
            return k;
        }
 
        for (char c = 'a'; c <= 'c'; c++) {
            if (current.Length > 0 && current[current.Length - 1] == c) 
                continue;
                
            current.Append(c);
            k = Backtracking(n, k, current);
            if (k == 0) return 0;
            current.Length--;
        }

        return k;
    }
}