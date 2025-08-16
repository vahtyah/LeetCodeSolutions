namespace LeetCodeSolutions.Math;

/*
 * 1323. Maximum 69 Number
 * Difficulty: Easy
 * Submission Time: 2025-08-16 06:17:27
 * Created by vahtyah on 2025-08-16 06:18:47
*/
 
public class Solution {
    public int Maximum69Number(int num) {
        var chars = num.ToString().ToCharArray();
        
        for (int i = 0; i < chars.Length; i++) {
            if (chars[i] == '6') {
                chars[i] = '9';
                break;
            }
        }
        
        return int.Parse(new string(chars));
    }
}