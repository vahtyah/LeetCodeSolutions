namespace LeetCodeSolutions.DataStructures/String;

/*
 * 0744. Find Smallest Letter Greater Than Target
 * Difficulty: Easy
 * Submission Time: 2026-01-31 12:21:43
 * Created by vahtyah on 2026-01-31 12:22:54
*/
 
public class Solution {
    public char NextGreatestLetter(char[] letters, char target) {
        foreach(var letter in letters){
            if(letter > target) return letter;
        }

        return letters[0];
    }
}