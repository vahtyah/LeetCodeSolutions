namespace LeetCodeSolutions.Math;

/*
 * 2081. Sum of k-Mirror Numbers
 * Difficulty: Hard
 * Submission Time: 2025-06-23 07:09:11
 * Created by vahtyah on 2025-06-23 07:09:32
*/
 
public class Solution {
    public long KMirror(int k, int n) {
        long sum = 0;
        int count = 0;
        int len = 1;
        while (count < n) {
            foreach (var num in GenerateBase10Palindromes(len)) {
                if (IsPalindromeInBaseK(num, k)) {
                    sum += num;
                    count++;
                    if (count == n) return sum;
                }
            }
            len++;
        }
        return sum;
    }

    private IEnumerable<long> GenerateBase10Palindromes(int len) {
        int half = (len + 1) / 2;
        long start = (long)Math.Pow(10, half - 1);
        long end = (long)Math.Pow(10, half);
        for (long i = start; i < end; i++) {
            long p = CreatePalindrome(i, len % 2 == 0);
            yield return p;
        }
    }

    private long CreatePalindrome(long half, bool even) {
        long result = half;
        if (!even) half /= 10;
        while (half > 0) {
            result = result * 10 + half % 10;
            half /= 10;
        }
        return result;
    }

    private bool IsPalindromeInBaseK(long num, int k) {
        int[] digits = new int[64];
        int len = 0;
        while (num > 0) {
            digits[len++] = (int)(num % k);
            num /= k;
        }
        for (int i = 0, j = len - 1; i < j; i++, j--) {
            if (digits[i] != digits[j]) return false;
        }
        return true;
    }
}