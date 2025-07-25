namespace LeetCodeSolutions.Searching/BinarySearch;

/*
 * 0300. Longest Increasing Subsequence
 * Difficulty: Medium
 * Submission Time: 2025-07-25 02:02:58
 * Created by vahtyah on 2025-07-25 02:04:15
*/
 
public class Solution {
    public int LengthOfLIS(int[] nums) {
        var tails = new int[nums.Length];
        var index = 0;

        foreach(var num in nums){
            int left = 0, right = index;
            while(left < right){
                var mid = left + ((right - left) / 2);
                if(tails[mid] < num) left = mid + 1;
                else right = mid;
            }

            if(left == index) tails[index++] = num;
            else tails[left] = num;
        }

        return index;
    }
}