namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 2780. Minimum Index of a Valid Split
 * Difficulty: Medium
 * Submission Time: 2025-03-27 06:36:05
 * Created by vahtyah on 2025-03-27 06:50:42
*/
 
public class Solution {
    public int MinimumIndex(IList<int> nums) {
        // Find dominant element using Boyer-Moore Voting algorithm
        int candidate = 0;
        int count = 0;
        
        foreach (int num in nums) {
            if (count == 0) {
                candidate = num;
            }
            count += (num == candidate) ? 1 : -1;
        }
        
        int n = nums.Count;
        int totalFreq = 0;
        int leftFreq = 0;
        
        for (int i = 0; i < n; i++) {
            if (nums[i] == candidate) totalFreq++;
        }
        
        if (totalFreq * 2 <= n + 1) return -1;
        
        for (int i = 0; i < n - 1; i++) {
            if (nums[i] == candidate) leftFreq++;
            int rightFreq = totalFreq - leftFreq;
            if ((leftFreq << 1) > (i + 1) && (rightFreq << 1) > (n - i - 1)) {
                return i;
            }
        }
        
        return -1;
    }
}