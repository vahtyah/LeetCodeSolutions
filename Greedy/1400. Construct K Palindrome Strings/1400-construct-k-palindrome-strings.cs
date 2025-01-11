public class Solution {
    public bool CanConstruct(string s, int k) {
        if (s.Length < k) return false;
        if (s.Length == k) return true; 
        
        // Use a bit manipulation approach to count odd frequencies
        int oddCount = 0;
        int mask = 0;
        
        foreach (char c in s) {
            mask ^= 1 << (c - 'a');
        }
        
        while (mask != 0) {
            oddCount += mask & 1;
            mask >>= 1;
        }
        
        return oddCount <= k;
    }
}

public class Solution {
    public bool CanConstruct(string s, int k) {
        if(s.Length < k) return false;

        var charFreq = new int[26];

        foreach(char c in s){
            charFreq[c - 'a']++;
        }

        var count = 0;
        foreach(var i in charFreq){
            if(i % 2 != 0) count++;
        }

        return count <= k;
    }
}