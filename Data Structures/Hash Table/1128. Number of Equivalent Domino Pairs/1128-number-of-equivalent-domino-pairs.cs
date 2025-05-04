namespace LeetCodeSolutions.DataStructures/HashTable;

/*
 * 1128. Number of Equivalent Domino Pairs
 * Difficulty: Easy
 * Submission Time: 2025-05-04 05:57:03
 * Created by vahtyah on 2025-05-04 05:59:26
*/
 
public class Solution {
    public int NumEquivDominoPairs(int[][] dominoes) {
        var counts = new int[100];
        var result = 0;
        
        foreach (var domino in dominoes) {
            int key = Math.Min(domino[0], domino[1]) * 10 + Math.Max(domino[0], domino[1]);
            result += counts[key];
            counts[key]++;
        }
        
        return result;
    }
}