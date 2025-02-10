namespace LeetCodeSolutions.DataStructures/Stack;

/*
 * 3174. Clear Digits
 * Difficulty: Easy
 * Submission Time: 2025-02-10 06:48:37
 * Created by vahtyah on 2025-02-10 06:54:39
*/

//Faster https://github.com/vahtyah/LeetCodeSolutions/tree/main/Data%20Structures/String/3174.%20Clear%20Digits
 
public class Solution {
    public string ClearDigits(string s) {
        var stack = new Stack<char>();
        
        for(int i = 0; i < s.Length; i++){
            if(Char.IsDigit(s[i])) stack.Pop();
            else stack.Push(s[i]);
        }

        return string.Concat(stack.Reverse());
    }
}
