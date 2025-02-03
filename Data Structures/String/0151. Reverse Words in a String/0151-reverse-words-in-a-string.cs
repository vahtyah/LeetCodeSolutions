namespace LeetCodeSolutions.DataStructures/String;

/*
 * 0151. Reverse Words in a String
 * Difficulty: Medium
 * Submission Time: 2025-02-03 06:36:34
 * Created by vahtyah on 2025-02-03 07:02:40
 */
 
public class Solution {
    public string ReverseWords(string s) {
        string[] words = s.Split(new char[] { ' ' }, 
            StringSplitOptions.RemoveEmptyEntries);
        
        Array.Reverse(words);
        
        return string.Join(" ", words);
    }
}