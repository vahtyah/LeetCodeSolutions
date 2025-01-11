public class Solution {
    public IList<string> WordSubsets(string[] words1, string[] words2) {
        int[] combinedFreq = new int[26];
        foreach (var word in words2) {
            int[] currentFreq = new int[26];
            foreach (var ch in word) {
                currentFreq[ch - 'a']++;
                if (currentFreq[ch - 'a'] > combinedFreq[ch - 'a']) {
                    combinedFreq[ch - 'a'] = currentFreq[ch - 'a'];
                }
            }
        }
        
        List<string> result = new List<string>();
        foreach (var word in words1) {
            int[] freq = new int[26];
            foreach (var ch in word) {
                freq[ch - 'a']++;
            }
            
            bool isUniversal = true;
            for (int i = 0; i < 26; i++) {
                if (freq[i] < combinedFreq[i]) {
                    isUniversal = false;
                    break;
                }
            }
            
            if (isUniversal) {
                result.Add(word);
            }
        }
        
        return result;
    }
}