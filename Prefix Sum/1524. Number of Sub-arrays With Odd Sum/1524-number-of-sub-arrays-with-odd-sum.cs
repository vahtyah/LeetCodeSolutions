namespace LeetCodeSolutions.PrefixSum;

/*
 * 1524. Number of Sub-arrays With Odd Sum
 * Difficulty: Medium
 * Submission Time: 2025-02-25 05:37:39
 * Created by vahtyah on 2025-02-25 05:40:02
*/
 
public class Solution
{
    public int NumOfSubarrays(int[] arr)
    {
        var oddCount = 0;
        var prefixSum = 0;

        foreach (var num in arr)
        {
            prefixSum += num;
            oddCount += prefixSum % 2;
        }
        

        var evenCount = arr.Length - oddCount;
        return (int)((1L * evenCount * oddCount + oddCount) % 1_000_000_007);
    }
}