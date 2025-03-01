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