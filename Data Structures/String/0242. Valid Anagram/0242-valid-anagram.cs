namespace LeetCodeSolutions.DataStructures/String;

/*
 * 0242. Valid Anagram
 * Difficulty: Easy
 * Submission Time: 2025-02-16 16:35:54
 * Created by vahtyah on 2025-02-16 16:37:41
*/
 
public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        var letters = new int[28];
        
        for(int i = 0; i < s.Length; i++){
            letters[s[i] - 'a']++;
            letters[t[i] - 'a']--;
        }
        
        foreach (var count in letters) {
            if (count != 0) return false;
        }

        return true;
    }
}