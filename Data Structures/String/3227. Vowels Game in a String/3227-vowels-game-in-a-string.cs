namespace LeetCodeSolutions.DataStructures/String;

/*
 * 3227. Vowels Game in a String
 * Difficulty: Medium
 * Submission Time: 2025-09-12 12:24:50
 * Created by vahtyah on 2025-09-12 12:25:29
*/
 
public class Solution {
    public bool DoesAliceWin(string s) {
        for (int i = 0; i < s.Length; i++)
            if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
                return true;
        return false;
    }
}