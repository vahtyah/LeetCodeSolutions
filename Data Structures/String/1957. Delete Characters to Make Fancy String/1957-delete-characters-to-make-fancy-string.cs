namespace LeetCodeSolutions.DataStructures/String;

/*
 * 1957. Delete Characters to Make Fancy String
 * Difficulty: Easy
 * Submission Time: 2025-07-21 07:36:15
 * Created by vahtyah on 2025-07-21 07:37:11
*/
 
public class Solution {
    public string MakeFancyString(string s) {
        if (s.Length < 3) return s;

        var chars = s.ToCharArray();
        int writePos = 2;

        for (int readPos = 2; readPos < chars.Length; readPos++) {
            if (chars[readPos] != chars[writePos - 1] || 
                chars[readPos] != chars[writePos - 2]) {
                chars[writePos++] = chars[readPos];
            }
        }

        return new string(chars, 0, writePos);
    }
}