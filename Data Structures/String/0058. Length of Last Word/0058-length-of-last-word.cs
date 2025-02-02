namespace LeetCodeSolutions.DataStructures/String;

/*
 * 0058. Length of Last Word
 * Difficulty: Easy
 * Submission Time: 2025-02-02 18:52:19
 * Created by vahtyah on 2025-02-02 18:52:39
 */
 
public class Solution {
    public int LengthOfLastWord(string s) {
        int length = 0;
        int i = s.Length - 1;

        while (i >= 0 && s[i] == ' ') {
            i--;
        }

        while (i >= 0 && s[i] != ' ') {
            length++;
            i--;
        }

        return length;
    }
}