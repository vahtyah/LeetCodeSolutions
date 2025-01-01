public class Solution {
    public int MaxScore(string s) {
        var totalZeros = 0;
        var totalOnes = 0;
        var maxScore = 0;

        foreach (char c in s) {
            if (c == '1') totalOnes++;
        }

        for(int i = 0; i < s.Length - 1; i++){
            if(s[i] == '1') totalOnes--;
            else totalZeros++;
            maxScore = Math.Max(maxScore, totalZeros + totalOnes);
        }

        return maxScore;
    }
}
