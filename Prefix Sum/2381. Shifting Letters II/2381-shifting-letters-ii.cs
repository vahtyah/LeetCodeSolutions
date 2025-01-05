public class Solution {
    public string ShiftingLetters(string s, int[][] shifts) {
        int n = s.Length;
        long[] prefix = new long[n + 1];
        
        // Difference array technique
        foreach (var shift in shifts) {
            int start = shift[0];
            int end = shift[1];
            int direction = shift[2] == 1 ? 1 : -1;
            
            prefix[start] += direction;
            prefix[end + 1] -= direction;
        }
        
        for (int i = 1; i < n; i++) {
            prefix[i] += prefix[i - 1];
        }
        
        char[] result = new char[n];
        
        for (int i = 0; i < n; i++) {
            long shift = ((s[i] - 'a' + prefix[i]) % 26 + 26) % 26; // To handle negative values [0, 25]
            result[i] = (char)('a' + shift);
        }
        
        return new string(result);
    }
}