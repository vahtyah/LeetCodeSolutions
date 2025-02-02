namespace LeetCodeSolutions.DataStructures/String;

/*
 * 0012. Integer to Roman
 * Difficulty: Medium
 * Submission Time: 2025-02-02 18:43:10
 * Created by vahtyah on 2025-02-02 18:43:41
 */
 
using System.Runtime.CompilerServices;
public class Solution {
    private static readonly string[] thousands = { "", "M", "MM", "MMM" };

    private static readonly string[] hundreds = {
        "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"
    };

    private static readonly string[] tens = { "",  "X",  "XX",  "XXX",  "XL",
                                              "L", "LX", "LXX", "LXXX", "XC" };

    private static readonly string[] ones = { "",  "I",  "II",  "III",  "IV",
                                              "V", "VI", "VII", "VIII", "IX" };
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public string IntToRoman(int num) {
        return thousands[num / 1000] + hundreds[num % 1000 / 100] +
               tens[num % 100 / 10] + ones[num % 10];
    }
}