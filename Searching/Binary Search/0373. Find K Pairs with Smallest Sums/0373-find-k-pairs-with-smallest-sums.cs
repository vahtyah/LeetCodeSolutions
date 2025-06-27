namespace LeetCodeSolutions.Searching/BinarySearch;

/*
 * 0373. Find K Pairs with Smallest Sums
 * Difficulty: Medium
 * Submission Time: 2025-06-27 07:09:19
 * Created by vahtyah on 2025-06-27 07:09:43
*/
 
public class Solution {
    public IList<IList<int>> KSmallestPairs(int[] nums1, int[] nums2, int k) {
        int n1 = nums1.Length, n2 = nums2.Length;
        int left = nums1[0] + nums2[0];
        int right = nums1[n1 - 1] + nums2[n2 - 1];
        
        while (left < right) {
            int mid = left + (right - left) / 2;
            if (CountPairs(nums1, nums2, mid) >= k) {
                right = mid;
            } else {
                left = mid + 1;
            }
        }
        
        return CollectPairs(nums1, nums2, left, k);
    }
    
    private long CountPairs(int[] nums1, int[] nums2, int target) {
        long count = 0;
        int j = nums2.Length - 1;
        
        for (int i = 0; i < nums1.Length; i++) {
            while (j >= 0 && nums1[i] + nums2[j] > target) {
                j--;
            }
            if (j >= 0) {
                count += j + 1;
            }
        }
        return count;
    }
    
    private List<IList<int>> CollectPairs(int[] nums1, int[] nums2, int target, int k) {
        var result = new List<IList<int>>();
        
        for (int i = 0; i < nums1.Length && result.Count < k; i++) {
            for (int j = 0; j < nums2.Length && result.Count < k; j++) {
                if (nums1[i] + nums2[j] < target) {
                    result.Add(new List<int> { nums1[i], nums2[j] });
                } else {
                    break;
                }
            }
        }
        
        for (int i = 0; i < nums1.Length && result.Count < k; i++) {
            for (int j = 0; j < nums2.Length && result.Count < k; j++) {
                if (nums1[i] + nums2[j] == target) {
                    result.Add(new List<int> { nums1[i], nums2[j] });
                } else if (nums1[i] + nums2[j] > target) {
                    break;
                }
            }
        }
        
        return result;
    }
}