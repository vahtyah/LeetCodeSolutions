namespace LeetCodeSolutions.DataStructures/String;

/*
 * 3174. Clear Digits
 * Difficulty: Easy
 * Submission Time: 2025-02-10 06:48:37
 * Created by vahtyah on 2025-02-10 06:49:06
*/
 
public class Solution {
    public string ClearDigits(string s) {
        var chars = new char[s.Length];
        var index = 0;

        foreach(var c in s){
            if(IsDigit(c)) index--;
            else chars[index++] = c;
        }

        return new string(chars, 0, index);
    }

    public bool IsDigit(char c){
        return c >= '0' && c <= '9';
    }
}