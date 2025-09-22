namespace LeetCodeSolutions.DataStructures/HashTable;

/*
 * 3005. Count Elements With Maximum Frequency
 * Difficulty: Easy
 * Submission Time: 2025-09-22 05:25:30
 * Created by vahtyah on 2025-09-22 12:16:49
*/
 
public class Solution {
    public int MaxFrequencyElements(int[] nums) {
        Span<int> freq = stackalloc int[101];
        var maxFreq = 0;
        var result = 0;

        foreach(var num in nums){
            freq[num]++;
            if(maxFreq < freq[num]){
                maxFreq = freq[num];
                result = maxFreq;
            }
            else if(maxFreq == freq[num]) result += maxFreq;
        }

        return result;
    }
}