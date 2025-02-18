namespace LeetCodeSolutions.Backtracking;

/*
 * 2375. Construct Smallest Number From DI String
 * Difficulty: Medium
 * Submission Time: 2025-02-18 06:34:59
 * Created by vahtyah on 2025-02-18 06:35:25
*/
 
public class Solution {
    public string SmallestNumber(string pattern) {
        int n = pattern.Length;
        char[] result = new char[n + 1];
        bool[] used = new bool[10]; // To track used digits (1-9)
        
        // Start backtracking from index 0
        Backtrack(pattern, 0, result, used);
        
        return new string(result);
    }
    
    private bool Backtrack(string pattern, int index, char[] result, bool[] used) {
        // Base case: if we've filled all positions, we've found our answer
        if (index == result.Length) {
            return true;
        }
        
        // Try digits 1-9
        for (int digit = 1; digit <= 9; digit++) {
            if (used[digit]) continue; // Skip if digit is already used
            
            // Check if current digit satisfies the pattern
            if (index > 0) {
                char prevDigit = result[index - 1];
                if (pattern[index - 1] == 'I' && digit <= (prevDigit - '0')) continue;
                if (pattern[index - 1] == 'D' && digit >= (prevDigit - '0')) continue;
            }
            
            // Place the digit and mark it as used
            result[index] = (char)(digit + '0');
            used[digit] = true;
            
            // Recursively try to fill the rest of the positions
            if (Backtrack(pattern, index + 1, result, used)) {
                return true;
            }
            
            // Backtrack: remove the digit and mark it as unused
            used[digit] = false;
        }
        
        return false;
    }
}