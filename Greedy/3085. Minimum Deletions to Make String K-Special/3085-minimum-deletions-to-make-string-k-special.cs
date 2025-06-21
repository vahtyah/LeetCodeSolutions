namespace LeetCodeSolutions.Greedy;

/*
 * 3085. Minimum Deletions to Make String K-Special
 * Difficulty: Medium
 * Submission Time: 2025-06-21 08:23:54
 * Created by vahtyah on 2025-06-21 08:24:41
*/
 
public class Solution {
    public int MinimumDeletions(string word, int k) {
        int[] freq = new int[26];

        foreach (char c in word) {
            freq[c - 'a']++;
        }

        Array.Sort(freq);
        Array.Reverse(freq);

        int minDeletions = int.MaxValue;

        for (int i = 0; i < 26 && freq[i] > 0; i++) {
            int deletions = 0;
            for (int j = 0; j < 26 && freq[j] > 0; j++) {
                if (i == j) continue;

                if (freq[j] < freq[i]) {
                    deletions += freq[j];
                } else {
                    int excess = freq[j] - (freq[i] + k);
                    if (excess > 0) {
                        deletions += excess;
                    }
                }
            }

            minDeletions = Math.Min(minDeletions, deletions);
        }

        return minDeletions;
    }
}
