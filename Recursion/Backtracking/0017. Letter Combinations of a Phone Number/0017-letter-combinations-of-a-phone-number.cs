namespace LeetCodeSolutions.Recursion/Backtracking;

/*
 * 0017. Letter Combinations of a Phone Number
 * Difficulty: Medium
 * Submission Time: 2025-01-10 11:53:16
 * Created by vahtyah on 2025-03-01 08:17:46
*/
 
public class Solution {

    private static readonly string[] digitToLetters = new string[] {
        "",     // 0
        "",     // 1
        "abc",  // 2
        "def",  // 3
        "ghi",  // 4
        "jkl",  // 5
        "mno",  // 6
        "pqrs", // 7
        "tuv",  // 8
        "wxyz"  // 9
    };

    public IList<string> LetterCombinations(string digits){
        var answer = new List<string>();
        BackTrack(digits, "", 0, answer);
        return answer;
    } 

    public void BackTrack(string digits, string text, int current, List<string> answer){
        if(text.Length == digits.Length){
            if(text.Length != 0)
                answer.Add(text);
            return;
        }
        var str = digitToLetters[digits[current] - '0'];
        for(int i = 0; i < str.Length; i++){
            BackTrack(digits, text + str[i], current + 1, answer);
        }
    }
}