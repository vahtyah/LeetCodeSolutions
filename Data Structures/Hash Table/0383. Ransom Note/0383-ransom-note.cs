namespace LeetCodeSolutions.DataStructures/HashTable;

/*
 * 0383. Ransom Note
 * Difficulty: Easy
 * Submission Time: 2025-02-05 07:53:19
 * Created by vahtyah on 2025-02-05 07:55:44
 */
 
// Although it doesn't use Hash Table, it's essentially a hash table technique with a fixed array.

public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        if (ransomNote.Length > magazine.Length) return false;
        
        Span<int> charCount = stackalloc int[26];
        
        foreach (char c in magazine) {
            charCount[c - 'a']++;
        }
        
        foreach (char c in ransomNote) {
            if (--charCount[c - 'a'] < 0) {
                return false;
            }
        }
        
        return true;
    }
}