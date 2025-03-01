namespace LeetCodeSolutions.Recursion/Backtracking;

/*
 * 0046. Permutations
 * Difficulty: Medium
 * Submission Time: 2025-02-17 06:23:26
 * Created by vahtyah on 2025-03-01 08:22:40
*/
 
public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        var permutations = new List<IList<int>>();
        FindPermutations(nums, 0, permutations);
        return permutations;
    }

    public void FindPermutations(int[] nums, int start, List<IList<int>> permutations){
        if(start == nums.Length){
            var perm = new int[nums.Length];
            Array.Copy(nums, perm, nums.Length);
            permutations.Add(perm);
            return;
        }

        for(int i = start; i < nums.Length; i++){
            if (i != start && nums[i] == nums[start]) continue;
            Swap(nums, start, i);
            FindPermutations(nums, start + 1, permutations);
            Swap(nums, i, start);
        }
    }

    private void Swap(int[] nums, int i, int j) {
        if (i == j) return; 
        nums[i] ^= nums[j];
        nums[j] ^= nums[i];
        nums[i] ^= nums[j];
    }
}