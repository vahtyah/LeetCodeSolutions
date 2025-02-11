namespace LeetCodeSolutions.DataStructures/String;

/*
 * 0205. Isomorphic Strings
 * Difficulty: Easy
 * Submission Time: 2025-02-11 08:49:48
 * Created by vahtyah on 2025-02-11 08:51:43
*/
 
public class Solution {
    public bool IsIsomorphic(string s, string t) {
        if (s.Length != t.Length) return false;
        
        var sToT = new char[128];
        var tToS = new char[128];
        
        for (int i = 0; i < s.Length; i++) {
            if (sToT[s[i]] == 0 && tToS[t[i]] == 0) {
                sToT[s[i]] = t[i];
                tToS[t[i]] = s[i];
            }
            else if (sToT[s[i]] != t[i] || tToS[t[i]] != s[i]) {
                return false;
            }
        }
        
        return true;
    }
}