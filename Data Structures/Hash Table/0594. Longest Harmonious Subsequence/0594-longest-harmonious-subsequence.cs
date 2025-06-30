namespace LeetCodeSolutions.DataStructures/HashTable;

/*
 * 0594. Longest Harmonious Subsequence
 * Difficulty: Easy
 * Submission Time: 2025-06-30 16:27:01
 * Created by vahtyah on 2025-06-30 16:27:51
*/
 
public class Solution 
{
    public int FindLHS(int[] nums) 
    {
        Dictionary<int, int> freq = new Dictionary<int, int>(nums.Length);
        int maxLength = 0;

        foreach(var num in nums) freq[num] = freq.GetValueOrDefault(num, 0) + 1;
        
        foreach (var pair in freq)
        {
            if (freq.TryGetValue(pair.Key + 1, out var freqMax))
                maxLength = Math.Max(maxLength, pair.Value + freqMax);
        }
        
        return maxLength;
    }
}