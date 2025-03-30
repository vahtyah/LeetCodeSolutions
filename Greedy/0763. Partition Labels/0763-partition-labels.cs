namespace LeetCodeSolutions.Greedy;

/*
 * 0763. Partition Labels
 * Difficulty: Medium
 * Submission Time: 2025-03-30 05:18:57
 * Created by vahtyah on 2025-03-30 05:19:28
*/
 
public class Solution {
    public IList<int> PartitionLabels(string s) {
        Span<int> lastPos = stackalloc int[26];
        
        for (int i = 0; i < s.Length; i++) {
            lastPos[s[i] - 'a'] = i;
        }
        
        var result = new List<int>();
        int start = 0;
        int end = 0;
        
        for (int i = 0; i < s.Length; i++) {
            end = Math.Max(end, lastPos[s[i] - 'a']);
            
            if (i == end) {
                result.Add(end - start + 1);
                start = i + 1;
            }
        }
        
        return result;
    }
}