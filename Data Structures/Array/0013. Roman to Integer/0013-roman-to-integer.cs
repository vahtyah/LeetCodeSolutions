namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 0013. Roman to Integer
 * Difficulty: Easy
 * Submission Time: 2025-02-02 17:09:56
 * Created by vahtyah on 2025-02-02 17:12:31
 */
 
public class Solution {
    private static readonly int[] values = new int[128];

    static Solution() {
        values['I'] = 1;
        values['V'] = 5;
        values['X'] = 10;
        values['L'] = 50;
        values['C'] = 100;
        values['D'] = 500;
        values['M'] = 1000;
    }

    public int RomanToInt(string s) {
        ReadOnlySpan<char> span = s.AsSpan();
        int length = span.Length;
        
        int result = values[span[length - 1]];
        
        for (int i = length - 2; i >= 0; i--) {
            int curr = values[span[i]];
            int next = values[span[i + 1]];
            result += curr < next ? -curr : curr;
        }
        
        return result;
    }
}