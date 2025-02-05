namespace LeetCodeSolutions.DataStructures/String;

/*
 * 1790. Check if One String Swap Can Make Strings Equal
 * Difficulty: Easy
 * Submission Time: 2025-02-05 06:50:29
 * Created by vahtyah on 2025-02-05 06:54:32
 */
 
public class Solution {
    public bool AreAlmostEqual(string s1, string s2) {
        if(s1.Equals(s2)) return true;
        var first = -1;
        var second = -1;

        for(int i = 0; i < s1.Length; i++){
            if(s1[i] == s2[i]) continue;
            if(first != -1 && second != -1) return false;
            if(first != -1) {
                second = i;
                if(s1[first] != s2[second] || s1[second] != s2[first]) return false;
            }
            else first = i;
        }
        return second != -1;
    }
}