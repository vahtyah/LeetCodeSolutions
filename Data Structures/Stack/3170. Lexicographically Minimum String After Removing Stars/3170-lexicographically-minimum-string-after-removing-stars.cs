namespace LeetCodeSolutions.DataStructures/Stack;

/*
 * 3170. Lexicographically Minimum String After Removing Stars
 * Difficulty: Medium
 * Submission Time: 2025-06-07 06:55:14
 * Created by vahtyah on 2025-06-07 06:55:57
*/
 
public class Solution {
    public string ClearStars(string s) {
        var n = s.Length;
        
        var span = s.AsSpan();
        
        bool hasStars = false;
        for (int i = 0; i < n; i++) {
            if (span[i] == '*') {
                hasStars = true;
                break;
            }
        }
        if (!hasStars) return s;
        
        var charStacks = new Stack<int>[26];
        var toRemove = new bool[n];
        
        for (int i = 0; i < n; i++) {
            char c = span[i];
            
            if (c == '*') {
                for (int j = 0; j < 26; j++) {
                    if (charStacks[j] != null && charStacks[j].Count > 0) {
                        int indexToRemove = charStacks[j].Pop();
                        toRemove[indexToRemove] = true;
                        break;
                    }
                }
                toRemove[i] = true;
            } else {
                int charIndex = c - 'a';
                charStacks[charIndex] ??= new Stack<int>();
                charStacks[charIndex].Push(i);
            }
        }
        
        var result = new StringBuilder(n);
        for (int i = 0; i < n; i++) {
            if (!toRemove[i]) {
                result.Append(span[i]);
            }
        }
        
        return result.ToString();
    }
}