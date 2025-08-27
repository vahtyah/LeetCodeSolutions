namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 0645. Set Mismatch
 * Difficulty: Easy
 * Submission Time: 2025-11-22 17:59:04
 * Created by vahtyah on 2025-12-11 14:59:57
*/
 
public class Solution {
    public int[] FindErrorNums(int[] nums) {
        var n = nums.Length;
        Span<bool> seen = stackalloc bool[n + 1];
        var result = new int[2];

        foreach(var num in nums){
            if(seen[num]) result[0] = num;
            seen[num] = true;
        }

        for(int i = 1; i <= n; i++){
            if(seen[i]) continue;
            result[1] = i;
            break;
        }

        return result;
    }
}