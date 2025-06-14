namespace LeetCodeSolutions.Greedy;

/*
 * 2566. Maximum Difference by Remapping a Digit
 * Difficulty: Easy
 * Submission Time: 2025-06-14 05:41:58
 * Created by vahtyah on 2025-06-14 05:42:21
*/
 
public class Solution {
    public int MinMaxDifference(int num) {
        string numStr = num.ToString();
        int length = numStr.Length;
        
        char maxReplaceChar = '0';
        for (int i = 0; i < length; i++) {
            if (numStr[i] != '9') {
                maxReplaceChar = numStr[i];
                break;
            }
        }
        
        char minReplaceChar = numStr[0];

        int maxValue = 0, minValue = 0;
        
        for (int i = 0; i < length; i++) {
            char currentDigit = numStr[i];
            
            maxValue = maxValue * 10 + ((currentDigit == maxReplaceChar) ? 9 : (currentDigit - '0'));
            if (currentDigit != minReplaceChar) minValue = minValue * 10 + (currentDigit - '0');
            else minValue = minValue * 10;
        }
        
        return maxValue - minValue;
    }
}