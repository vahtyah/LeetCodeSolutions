namespace LeetCodeSolutions.Math;

/*
 * 3335. Total Characters in String After Transformations I
 * Difficulty: Medium
 * Submission Time: 2025-05-13 06:52:33
 * Created by vahtyah on 2025-05-13 07:11:44
*/
 
public class Solution {
    private const int MOD = 1_000_000_007;

    public int LengthAfterTransformations(string s, int t) {
        var freq = new int[26];
        foreach (var c in s)
            freq[c - 'a']++;

        var z = 25;
        for (var i = 0; i < t; i++) {
            var countZ = freq[z];
            freq[z] = 0;

            z = (z + 25) % 26; 
            var a = (z + 1) % 26; 
            var b = (z + 2) % 26;

            freq[a] = (freq[a] + countZ) % MOD;
            freq[b] = (freq[b] + countZ) % MOD;
        }
        
        return freq.Aggregate((x, y) => (x + y) % MOD);
    }
}