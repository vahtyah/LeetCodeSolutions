namespace LeetCodeSolutions.DataStructures/String;

/*
 * 3136. Valid Word
 * Difficulty: Easy
 * Submission Time: 2025-07-15 09:31:28
 * Created by vahtyah on 2025-07-15 09:36:38
*/
 
public class Solution {
    private static HashSet<char> vovels = new() {'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};

    public bool IsValid(string word) {
        if(word.Length < 3) return false;

        var hasVovel = false;
        var hasConsonant = false;

        foreach(var c in word){
            if(c == '@' || c == '#' || c == '$') return false;
            if(vovels.Contains(c)) hasVovel = true;
            else if(c < '0' || c > '9') hasConsonant = true;
        }

        return hasVovel && hasConsonant;
    }
}