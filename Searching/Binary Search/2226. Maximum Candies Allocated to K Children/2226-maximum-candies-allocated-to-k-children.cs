namespace LeetCodeSolutions.Searching/BinarySearch;

/*
 * 2226. Maximum Candies Allocated to K Children
 * Difficulty: Medium
 * Submission Time: 2025-03-14 04:47:41
 * Created by vahtyah on 2025-03-14 04:54:00
*/
 
public class Solution {
    public int MaximumCandies(int[] candies, long k) {
        var totalCandies = 0L;
        var max = 0;
        foreach (int candy in candies) {
            totalCandies += candy;
            max = Math.Max(candy, max);
        }
        
        if (totalCandies < k) return 0;

        int left = 1;
        int right = max;
        int result = 0;
        
        while (left <= right) {
            int mid = left + (right - left) / 2;
            
            if (CanDistribute(candies, k, mid)) {
                result = mid;
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }
        
        return result;
    }
    
    private bool CanDistribute(int[] candies, long k, int candiesPerChild) {
        long childrenServed = 0;
        
        foreach (int pile in candies) {
            childrenServed += pile / candiesPerChild;
            if (childrenServed >= k) return true;
        }
        
        return false;
    }
}