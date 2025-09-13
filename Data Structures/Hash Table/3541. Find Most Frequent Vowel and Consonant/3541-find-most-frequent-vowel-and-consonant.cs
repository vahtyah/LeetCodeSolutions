namespace LeetCodeSolutions.DataStructures/HashTable;

/*
 * 3541. Find Most Frequent Vowel and Consonant
 * Difficulty: Easy
 * Submission Time: 2025-09-13 06:25:04
 * Created by vahtyah on 2025-09-13 06:28:43
*/
 
public class Solution {
    public int MaxFreqSum(string s) {
        var freq = new int[26];

        foreach(var c in s) freq[c - 'a']++;

        var maxVowels = 0;
        var maxConsonant = 0;

        for(int i = 0; i < 26; i++){
            if(i == 0 || i == 4 || i == 8 || i == 14 || i == 20) maxVowels = Math.Max(maxVowels, freq[i]);
            else maxConsonant = Math.Max(maxConsonant, freq[i]);
        }

        return maxVowels + maxConsonant;
    }
}