namespace LeetCodeSolutions.DataStructures/HashTable;

/*
 * 0049. Group Anagrams
 * Difficulty: Medium
 * Submission Time: 2025-02-16 19:13:32
 * Created by vahtyah on 2025-02-16 19:13:59
*/
 
public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var groups = new Dictionary<string, List<string>>();
        
        foreach (string str in strs) {
            var counts = new char[26]; 
        
            foreach (char c in str) {
                counts[c - 'a']++;
            }
            string key = new string(counts);

            if (!groups.TryGetValue(key, out var list)) {
                list = new List<string>();
                groups[key] = list;
            }
            list.Add(str);
        }
        
        return groups.Values.ToList<IList<string>>();
    }
}