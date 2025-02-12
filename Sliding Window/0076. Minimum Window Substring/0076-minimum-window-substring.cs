namespace LeetCodeSolutions.SlidingWindow;

/*
 * 0076. Minimum Window Substring
 * Difficulty: Hard
 * Submission Time: 2025-02-12 09:53:05
 * Created by vahtyah on 2025-02-12 09:55:28
*/
 
public class Solution {
    public string MinWindow(string s, string t) {
        // Handle edge cases
        if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t) || s.Length < t.Length) {
            return "";
        }

        // Create frequency map for characters with size 128 (ASCII)
        int[] map = new int[128];
        int count = t.Length; // Counter for remaining characters to match
        int start = 0, end = 0; // Window pointers
        int minLen = int.MaxValue; // Length of minimum window
        int startIndex = 0; // Starting index of minimum window

        // Fill the map with character frequencies from string t
        foreach (char c in t) {
            map[c]++;
        }

        // Convert s to char array for better performance
        char[] chS = s.ToCharArray();

        // Sliding window algorithm
        while (end < chS.Length) {
            // Expand window by including character at end pointer
            if (map[chS[end++]]-- > 0) {
                count--;
            }

            // Try to minimize window when we have found all characters
            while (count == 0) {
                // Update minimum window if current window is smaller
                if (end - start < minLen) {
                    startIndex = start;
                    minLen = end - start;
                }

                // Contract window from start
                if (map[chS[start++]]++ == 0) {
                    count++;
                }
            }
        }

        // Return minimum window substring or empty string if not found
        return minLen == int.MaxValue ? "" : new string(chS, startIndex, minLen);
    }
}