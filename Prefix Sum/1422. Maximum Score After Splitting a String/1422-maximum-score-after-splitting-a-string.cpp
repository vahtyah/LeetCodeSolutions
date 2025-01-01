public class Solution {
    public int MaxScore(string s) {
        var prefix = new int[s.Length];
        var suffix = new int[s.Length];
        prefix[0] = s[0] == '0' ? 1 : 0;
        suffix[s.Length - 1] = s[s.Length - 1] == '1' ? 1 : 0;

        for(int i = 1; i < prefix.Length; i++){
            prefix[i] = prefix[i - 1] + (s[i] == '0' ? 1 : 0);
        }

        for(int i = suffix.Length - 2; i >= 0; i--){
            suffix[i] = suffix[i + 1] + (s[i] == '1' ? 1 : 0);
        }

        int maxScore = 0;
        for(int i = 0; i < s.Length - 1; i++){
            maxScore = Math.Max(maxScore, prefix[i] + suffix[i + 1]);
        }

        return maxScore;
    }
}
