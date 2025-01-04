public class Solution {
    public int CountPalindromicSubsequence(string s) {
        // Create arrays to store first and last occurrences instead of using Dictionary for better performance
        int[] first = new int[26];
        int[] last = new int[26];
        Array.Fill(first, -1);
        Array.Fill(last, -1);
        
        // Find first and last occurrences in a single pass
        for (int i = 0; i < s.Length; i++) {
            int idx = s[i] - 'a';
            if (first[idx] == -1) {
                first[idx] = i;
            }
            last[idx] = i;
        }
        
        int answer = 0;
        // Use boolean array instead of HashSet for better performance
        bool[] seen = new bool[26];
        
        // Count unique characters between first and last occurrence
        for (int i = 0; i < 26; i++) {
            if (first[i] < last[i]) {  // Valid range exists
                Array.Fill(seen, false);  // Reset seen array
                
                // Count unique characters between first and last occurrence
                for (int j = first[i] + 1; j < last[i]; j++) {
                    seen[s[j] - 'a'] = true;
                }
                
                // Count unique characters
                for (int j = 0; j < 26; j++) {
                    if (seen[j]) answer++;
                }
            }
        }
        
        return answer;
    }
}