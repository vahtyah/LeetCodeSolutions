namespace LeetCodeSolutions.DataStructures/String;

/*
 * 2785. Sort Vowels in a String
 * Difficulty: Medium
 * Submission Time: 2025-09-11 12:03:27
 * Created by vahtyah on 2025-09-11 12:04:02
*/
 
public class Solution {
    private readonly static HashSet<char> Vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

    public string SortVowels(string s) {
        var n = s.Length;

        var vowelFreq = new int[60];
        var chars = new char[n];

        for(int i = 0; i < n; i++){
            if(Vowels.Contains(s[i])) vowelFreq[s[i] - 'A']++;
            else chars[i] = s[i];
        }

        var index = 0;

        for(int i = 0; i < 60; i++){
            for(int j = 0; j < vowelFreq[i]; j++){
                for(;index < n; index++){
                    if(chars[index] == '\0'){
                        chars[index++] = (char)(i + 'A');
                        break;
                    }
                }
            }
        }

        return new string(chars);
    }
}