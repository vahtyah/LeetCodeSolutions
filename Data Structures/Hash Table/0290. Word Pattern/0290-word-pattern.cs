namespace LeetCodeSolutions.DataStructures/HashTable;

/*
 * 0290. Word Pattern
 * Difficulty: Easy
 * Submission Time: 2025-02-16 16:21:37
 * Created by vahtyah on 2025-02-16 16:22:06
*/
 
public class Solution {
    public bool WordPattern(string pattern, string s) {
        var words = s.Split(' ');
        if (words.Length != pattern.Length) return false;
        
        var charToWord = new string[26];
        var seenWord = new HashSet<string>(pattern.Length);

        for (int i = 0; i < words.Length; i++){
            if(charToWord[pattern[i] - 'a'] != null){
                if(charToWord[pattern[i] - 'a'] != words[i]) return false;
            }
            else{
                if(seenWord.Contains(words[i])) return false;
                seenWord.Add(words[i]);
                charToWord[pattern[i] - 'a'] = words[i];
            }
        }

        return true;
    }
}