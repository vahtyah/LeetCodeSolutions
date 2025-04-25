namespace LeetCodeSolutions.PrefixSum;

/*
 * 2845. Count of Interesting Subarrays
 * Difficulty: Medium
 * Submission Time: 2025-04-25 06:10:04
 * Created by vahtyah on 2025-04-25 06:11:49
*/
 
public class Solution {
    public long CountInterestingSubarrays(IList<int> nums, int modulo, int k) {
        var prefixCount = new Dictionary<int, int> { [0] = 1 };
        
        int prefixSum = 0;
        long result = 0;
        
        foreach (var num in nums) {
            if (num % modulo == k) {
                prefixSum = (prefixSum + 1) % modulo;
            }
            
            int target = (prefixSum - k + modulo) % modulo;
            
            if (prefixCount.TryGetValue(target, out int count)) {
                result += count;
            }
            
            prefixCount[prefixSum] = prefixCount.TryGetValue(prefixSum, out int currentCount) 
                ? currentCount + 1 
                : 1;
        }
        
        return result;
    }
}