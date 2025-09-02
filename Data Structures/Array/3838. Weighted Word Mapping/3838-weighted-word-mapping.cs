namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 3838. Weighted Word Mapping
 * Difficulty: Easy
 * Submission Time: 2026-06-13 04:49:49
 * Created by vahtyah on 2026-06-13 04:50:23
*/
 
public class Solution {
    public string MapWordWeights(string[] words, int[] weights) {
        var n = words.Length;
        var chars = new char[n];

        for(int i = 0; i < n; i++){
            var total = 0;
            for(int j = 0; j < words[i].Length; j++){
                total += weights[words[i][j] - 'a'];
            }
            total %= 26;
            chars[i] = (char)('z' - total);
        }

        return new string(chars);
    }
}