namespace LeetCodeSolutions.PrefixSum;

/*
 * 1590. Make Sum Divisible by P
 * Difficulty: Medium
 * Submission Time: 2025-11-30 10:10:52
 * Created by vahtyah on 2025-11-30 12:00:11
*/
 
public class Solution {
    public int MinSubarray(int[] nums, int p) {
        var n = nums.Length;
        
        long totalSum = 0;
        foreach(var num in nums) totalSum += num;
        
        var target = (int)(totalSum % p);
        if (target == 0) return 0;

        var modMap = new Dictionary<int, int>{{0, -1}};
        var minLen = n + 1;
        long prefixSum = 0;

        for(int i = 0; i < n; i++){
            prefixSum += nums[i];
            var curMod = (int)(prefixSum % p);
            var preMod = (curMod - target + p) % p;
            
            if(modMap.TryGetValue(preMod, out var preIndex)) {
                minLen = Math.Min(minLen, i - preIndex);
            }
            
            modMap[curMod] = i;
        }

        return minLen >= n ? -1 : minLen;
    }
}