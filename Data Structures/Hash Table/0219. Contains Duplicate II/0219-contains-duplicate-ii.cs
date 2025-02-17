namespace LeetCodeSolutions.DataStructures/HashTable;

/*
 * 0219. Contains Duplicate II
 * Difficulty: Easy
 * Submission Time: 2025-02-17 07:55:44
 * Created by vahtyah on 2025-02-17 07:56:03
*/
 
public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        if (nums.Length < 2 || k <= 0) {
            return false;
        }

        var numIndices = new Dictionary<int, int>(nums.Length);

        for (int i = 0; i < nums.Length; i++) {
            if (!numIndices.TryAdd(nums[i], i)) {
                if (i - numIndices[nums[i]] <= k) {
                    return true;
                }
                numIndices[nums[i]] = i;
            }
        }

        return false;
    }
}