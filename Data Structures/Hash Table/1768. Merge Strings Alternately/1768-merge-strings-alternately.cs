namespace LeetCodeSolutions.Data Structures/Hash Table;

/*
 * 1768. Merge Strings Alternately
 * Difficulty: Easy
 * Submission Time: 2025-01-31 15:25:16
 * Created by vahtyah on 2025-02-01 20:18:01
*/
 
public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int a = word1.Length;
        int b = word2.Length;
        int minno = Math.Min(a, b);
        string answer = "";

        for (int i = 0; i < minno; i++)
        {
            answer = answer + word1[i] + word2[i];
        }

        if(a > b)
        {
            string endstring = word1.Substring(minno);
            answer = answer + endstring;
        }
        else if(b > a)
        {
            string endstring = word2.Substring(minno);
            answer = answer + endstring;
        }

        return answer;
    }
}