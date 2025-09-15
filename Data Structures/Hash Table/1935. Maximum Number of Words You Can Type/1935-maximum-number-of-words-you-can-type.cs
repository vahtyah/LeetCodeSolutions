namespace LeetCodeSolutions.DataStructures/HashTable;

/*
 * 1935. Maximum Number of Words You Can Type
 * Difficulty: Easy
 * Submission Time: 2025-09-15 12:41:16
 * Created by vahtyah on 2025-09-15 12:41:46
*/
 
public class Solution {
    public int CanBeTypedWords(string text, string brokenLetters) {
        var brokenLettersArray = new bool[26];
        foreach(var c in brokenLetters) brokenLettersArray[c - 'a'] = true;

        var n = text.Length;
        var count = 0;
        var canType = true;

        for(int i = 0; i < n; i++){
            if(text[i] == ' '){
                if(canType) count++;
                canType = true;
            }
            else if(brokenLettersArray[text[i] - 'a']){
                canType = false;
            }
        }

        if(canType) count++;

        return count;
    }
}