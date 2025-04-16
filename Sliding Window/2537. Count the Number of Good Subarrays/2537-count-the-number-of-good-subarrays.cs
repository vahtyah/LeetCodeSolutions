namespace LeetCodeSolutions.SlidingWindow;

/*
 * 2537. Count the Number of Good Subarrays
 * Difficulty: Medium
 * Submission Time: 2025-04-16 06:35:03
 * Created by vahtyah on 2025-04-16 06:35:24
*/
 
public class Solution {
    public long CountGood(int[] nums, int k) {
        if (nums == null || nums.Length == 0 || k <= 0) {
            return k <= 0 ? (long)nums.Length * (nums.Length + 1) / 2 : 0;
        }
        
        int n = nums.Length;
        long result = 0;
        int pairsCount = 0;
        int right = 0;
        
        Dictionary<int, int> frequency = new Dictionary<int, int>(n / 2);
        
        for (int left = 0; left < n; left++) {
            while (pairsCount < k && right < n) {
                int current = 0;
                frequency.TryGetValue(nums[right], out current);
                
                pairsCount += current;
                frequency[nums[right]] = current + 1;
                right++;
            }
            
            if (pairsCount >= k) {
                result += n - (right - 1);
            }
            
            frequency[nums[left]]--;
            pairsCount -= frequency[nums[left]];
        }
        
        return result;
    }
}