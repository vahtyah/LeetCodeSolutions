namespace LeetCodeSolutions.StringMatching;

/*
 * 1910. Remove All Occurrences of a Substring
 * Difficulty: Medium
 * Submission Time: 2025-02-11 07:30:10
 * Created by vahtyah on 2025-02-11 07:31:24
*/
 
public class Solution {
    public string RemoveOccurrences(string s, string part) {
        var n = s.Length;
        var subLen = part.Length;
        var chars = new char[n];
        var index = 0;
        var newSub = "";
        for(var i = 0; i < n; i++){
            chars[index] = s[i];
            if(s[i] != part[subLen - 1] || index < subLen - 1) {
                index++;
                continue;
            }
            newSub = new String(chars, index - subLen + 1, subLen);
            if(newSub == part) index -= subLen - 1;
            else index++;
        }

        return new String(chars, 0, index);
    }
}