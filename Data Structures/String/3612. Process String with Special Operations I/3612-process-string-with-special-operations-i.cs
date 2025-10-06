namespace LeetCodeSolutions.DataStructures/String;

/*
 * 3612. Process String with Special Operations I
 * Difficulty: Medium
 * Submission Time: 2026-06-16 02:14:20
 * Created by vahtyah on 2026-06-16 02:14:42
*/
 
using System.Buffers;

public class Solution {
    public string ProcessStr(string s) {
        int maxLen = CalculateMaxLength(s);
        char[] buffer = ArrayPool<char>.Shared.Rent(maxLen);
        int len = 0;

        try {
            foreach (char c in s) {
                if (c >= 'a' && c <= 'z')
                    buffer[len++] = c;
                else if (c == '*') {
                    if (len > 0) len--;
                }
                else if (c == '#') {
                    Array.Copy(buffer, 0, buffer, len, len);
                    len *= 2;
                }
                else {
                    Reverse(buffer, len);
                }
            }

            return new string(buffer, 0, len);
        }
        finally {
            ArrayPool<char>.Shared.Return(buffer);
        }
    }

    private static void Reverse(char[] buffer, int len) {
        for (int i = 0, j = len - 1; i < j; i++, j--)
            (buffer[i], buffer[j]) = (buffer[j], buffer[i]);
    }

    private static int CalculateMaxLength(string s) {
        long len = 0;
        foreach (char c in s) {
            if (c >= 'a' && c <= 'z') len++;
            else if (c == '#') len *= 2;
            if (len > 1 << 24) return 1 << 24;
        }
        return Math.Max((int)len, 16);
    }
}