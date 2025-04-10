namespace LeetCodeSolutions.DynamicProgramming;

/*
 * 2999. Count the Number of Powerful Integers
 * Difficulty: Hard
 * Submission Time: 2025-04-10 05:13:10
 * Created by vahtyah on 2025-04-10 05:13:46
*/
 
public class Solution {
    public long NumberOfPowerfulInt(long start, long finish, int limit, string s) {
        foreach (char c in s) {
            if (c - '0' > limit) return 0;
        }
        string startStr = (start - 1).ToString();
        string finishStr = finish.ToString();
        return CountPowerful(finishStr, s, limit) - CountPowerful(startStr, s, limit);
    }

    private long CountPowerful(string x, string s, int limit) {
        if (x.Length < s.Length) {
            return 0;
        }
        if (x.Length == s.Length) {
            return string.Compare(x, s) >= 0 ? 1 : 0;
        }

        string suffix = x.Substring(x.Length - s.Length);
        long count = 0;
        int preLen = x.Length - s.Length;

        for (int i = 0; i < preLen; i++) {
            int digit = x[i] - '0';
            if (limit < digit) {
                count += (long)Math.Pow(limit + 1, preLen - i);
                return count;
            }
            count += (long)digit * (long)Math.Pow(limit + 1, preLen - 1 - i);
        }
        if (string.Compare(suffix, s) >= 0) {
            count++;
        }
        return count;
    }
}