namespace LeetCodeSolutions.Greedy;

/*
 * 1526. Minimum Number of Increments on Subarrays to Form a Target Array
 * Difficulty: Hard
 * Submission Time: 2025-10-30 05:30:11
 * Created by vahtyah on 2025-10-30 14:17:49
*/
 
public class Solution {
    public int MinNumberOperations(int[] target) {
        var operations = target[0];
        var prev = target[0];

        for(int i = 1; i < target.Length; i++){
            if(target[i] > prev) operations += target[i] - prev;
            prev = target[i];
        }

        return operations;
    }
}