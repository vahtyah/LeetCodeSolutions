namespace LeetCodeSolutions.DataStructures/String;

/*
 * 0014. Longest Common Prefix
 * Difficulty: Easy
 * Submission Time: 2025-02-02 19:10:06
 * Created by vahtyah on 2025-02-02 19:10:32
 */
 
public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if(strs == null || strs.Length == 0){
            return "";
        }
        string prefix = strs[0];
        for(int i = 1; i < strs.Length; i++){
            while(!strs[i].StartsWith(prefix)){
                prefix = prefix.Substring(0, prefix.Length - 1);
                if(string.IsNullOrEmpty(prefix)){
                    return "";
                }
            }
        }
        return prefix;

    }
}