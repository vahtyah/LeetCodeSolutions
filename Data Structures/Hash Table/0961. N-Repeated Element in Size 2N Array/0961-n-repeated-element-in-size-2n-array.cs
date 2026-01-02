namespace LeetCodeSolutions.DataStructures/HashTable;

/*
 * 0961. N-Repeated Element in Size 2N Array
 * Difficulty: Easy
 * Submission Time: 2026-01-02 14:29:57
 * Created by vahtyah on 2026-01-02 14:30:19
*/
 
public class Solution {
    public int RepeatedNTimes(int[] nums) {
        var n = nums.Length / 2;
        Span<int> freq = stackalloc int[10001];

        foreach(var num in nums){
            freq[num]++;
            if(freq[num] == n) return num;
        }

        return 0;
    }
}