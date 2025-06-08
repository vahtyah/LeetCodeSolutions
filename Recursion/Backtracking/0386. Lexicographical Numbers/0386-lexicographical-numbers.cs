namespace LeetCodeSolutions.Recursion/Backtracking;

/*
 * 0386. Lexicographical Numbers
 * Difficulty: Medium
 * Submission Time: 2025-06-08 06:08:36
 * Created by vahtyah on 2025-06-08 06:11:09
*/
 
public class Solution {
    public IList<int> LexicalOrder(int n) {
        var result = new List<int>(n);
        int current = 1;
        
        for (int i = 0; i < n; i++) {
            result.Add(current);
            
            if (current * 10 <= n) {
                current *= 10;
            }
            else if (current % 10 != 9 && current + 1 <= n) {
                current++;
            }
            // Backtrack: go up and try next branch
            else {
                // Remove trailing 9s and increment
                while ((current / 10) % 10 == 9) {
                    current /= 10;
                }
                current = current / 10 + 1;
            }
        }
        
        return result;
    }
}