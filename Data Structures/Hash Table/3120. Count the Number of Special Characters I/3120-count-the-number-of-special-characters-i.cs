namespace LeetCodeSolutions.DataStructures/HashTable;

/*
 * 3120. Count the Number of Special Characters I
 * Difficulty: Easy
 * Submission Time: 2026-05-26 03:00:03
 * Created by vahtyah on 2026-05-26 03:04:05
*/
 
public class Solution {
    public int NumberOfSpecialChars(string word) {
        var seen = new bool[252];
        var count = 0;

        for(int i = 0; i < word.Length; i++){
            var ch = word[i];
            if(seen[ch]) continue;
            if(ch > 96 && seen[ch - 32]) count++;
            if(ch < 96 && seen[ch + 32]) count++;

            seen[ch] = true; 
        }

        return count;
    }
}