namespace LeetCodeSolutions.Searching/BinarySearch;

/*
 * 2616. Minimize the Maximum Difference of Pairs
 * Difficulty: Medium
 * Submission Time: 2025-06-13 05:10:23
 * Created by vahtyah on 2025-06-13 05:12:17
*/
 
public class Solution {
    public int MinimizeMax(int[] nums, int p) {
        if (p == 0) return 0;
        
        Array.Sort(nums);
        int n = nums.Length;
        int left = 0, right = nums[n - 1] - nums[0];

        while(left < right){
            int mid = left + ((right - left) >> 1);
            
            if(CanFormPairs(nums, p, mid)) {
                right = mid;
            } else {
                left = mid + 1;
            }
        }

        return left;
    }
    
    //Greedy
    private bool CanFormPairs(int[] nums, int p, int maxDiff) {
        int pairs = 0;

        for(int i = 1; i < nums.Length; i++){
            if(nums[i] - nums[i - 1] <= maxDiff) {
                i++;
                if(++pairs >= p) return true;
            }
        }
        
        return false;
    }
}