namespace LeetCodeSolutions.DataStructures/String;

/*
 * 3461. Check If Digits Are Equal in String After Operations I
 * Difficulty: Easy
 * Submission Time: 2025-10-23 13:24:04
 * Created by vahtyah on 2025-10-23 13:26:22
*/
 
public class Solution {
    public bool HasSameDigits(string s) {
        var n = s.Length;
        var arr = s.ToCharArray();

        for(int i = 0; i < n - 2; i++){
            for(int j = 0; j < n - i - 1; j++){
                var first = arr[j] - '0';
                var second = arr[j + 1] - '0';

                arr[j] = (char)(((first + second) % 10) + '0');
            }
        }

        return arr[0] == arr[1];
    }
}