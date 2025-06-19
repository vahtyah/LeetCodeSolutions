namespace LeetCodeSolutions.Greedy;

/*
 * 2294. Partition Array Such That Maximum Difference Is K
 * Difficulty: Medium
 * Submission Time: 2025-06-19 05:56:44
 * Created by vahtyah on 2025-06-19 05:57:10
*/
 
public class Solution {
    public int PartitionArray(int[] nums, int k) {
        Array.Sort(nums);
        
        int partitions = 0;
        int i = 0;
        
        while (i < nums.Length) {
            int minValue = nums[i];
            
            while (i < nums.Length && nums[i] - minValue <= k) {
                i++;
            }
            
            partitions++;
        }
        
        return partitions;
    }
}