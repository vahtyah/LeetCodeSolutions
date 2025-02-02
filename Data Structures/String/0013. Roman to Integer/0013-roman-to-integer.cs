namespace LeetCodeSolutions.DataStructures/String;

/*
 * 0013. Roman to Integer
 * Difficulty: Easy
 * Submission Time: 2025-02-02 17:09:56
 * Created by vahtyah on 2025-02-02 18:45:33
 */
 
using System.Runtime.CompilerServices;

public class Solution {
    static readonly int[] dic = new int[26];

    static Solution() {
        dic['I' - 'A'] = 1;
        dic['V' - 'A'] = 5;
        dic['X' - 'A'] = 10;
        dic['L' - 'A'] = 50;
        dic['C' - 'A'] = 100;
        dic['D' - 'A'] = 500;
        dic['M' - 'A'] = 1000;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int RomanToInt(string s) {

        var lastValue = dic[s[0] - 'A'];
        var result = lastValue;

        for(var index = 1; index < s.Length; index++)
        {
            var currentValue = dic[s[index] - 'A'];
            result += currentValue;

            if(currentValue > lastValue)
            {
                result -= (2 * lastValue);
            }

            lastValue = currentValue;
        }

        return result;
    }
}