namespace LeetCodeSolutions.Greedy;

/*
 * 2375. Construct Smallest Number From DI String
 * Difficulty: Medium
 * Submission Time: 2025-02-18 06:29:23
 * Created by vahtyah on 2025-02-18 06:30:51
*/
 
public class Solution {
    public string SmallestNumber(string pattern) {
        var n = pattern.Length;
        var sequence = new char[n + 1];
        var previousIndex = 0;
        
        for (var i = 0; i <= n; i++) {
            sequence[i] = (char)(i + '1');
            if (i == n || pattern[i] == 'I') {
                Array.Reverse(sequence, previousIndex, i - previousIndex + 1);
                previousIndex = i + 1;
            }
        }

        return new string(sequence);
    }
}