namespace LeetCodeSolutions.Greedy;

/*
 * 1432. Max Difference You Can Get From Changing an Integer
 * Difficulty: Medium
 * Submission Time: 2025-06-15 07:30:15
 * Created by vahtyah on 2025-06-15 07:31:33
*/
 
public class Solution {
    public int MaxDiff(int num) {
        string numStr = num.ToString();
        
        char maxReplace = FindMaxReplace(numStr);
        char minReplace = FindMinReplace(numStr);
        
        int maxValue = 0, minValue = 0;
        char minReplaceWith = (numStr[0] == minReplace) ? '1' : '0';
        
        for (int i = 0; i < numStr.Length; i++) {
            char c = numStr[i];
            
            maxValue = maxValue * 10 + (c == maxReplace ? 9 : c - '0');
            minValue = minValue * 10 + (c == minReplace ? minReplaceWith - '0' : c - '0');
        }
        
        return maxValue - minValue;
    }
    
    private char FindMaxReplace(string numStr) {
        for (int i = 0; i < numStr.Length; i++) {
            if (numStr[i] != '9') {
                return numStr[i];
            }
        }
        return '#';
    }
    
    private char FindMinReplace(string numStr) {
        if (numStr[0] != '1') {
            return numStr[0];
        }
        
        for (int i = 1; i < numStr.Length; i++) {
            if (numStr[i] != '0' && numStr[i] != '1') {
                return numStr[i];
            }
        }
        
        return '#';
    }
}