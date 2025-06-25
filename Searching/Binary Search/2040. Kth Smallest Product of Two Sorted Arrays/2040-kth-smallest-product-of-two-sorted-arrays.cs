namespace LeetCodeSolutions.Searching/BinarySearch;

/*
 * 2040. Kth Smallest Product of Two Sorted Arrays
 * Difficulty: Hard
 * Submission Time: 2025-06-25 07:14:26
 * Created by vahtyah on 2025-06-25 07:15:01
*/
 
public class Solution {
    public long KthSmallestProduct(int[] nums1, int[] nums2, long k) {
        int n1 = nums1.Length, n2 = nums2.Length;
        
        int pos1 = FindFirstNonNegative(nums1);
        int pos2 = FindFirstNonNegative(nums2);
        
        long left = GetMinProduct(nums1, nums2);
        long right = GetMaxProduct(nums1, nums2);
        
        while (left < right) {
            long mid = left + ((right - left) >> 1);
            
            if (CountProductsLessOrEqual(nums1, nums2, pos1, pos2, mid) >= k) {
                right = mid;
            } else {
                left = mid + 1;
            }
        }
        
        return left;
    }
    
    private int FindFirstNonNegative(int[] nums) {
        if (nums[0] >= 0) return 0;
        if (nums[nums.Length - 1] < 0) return nums.Length;
        
        int left = 0, right = nums.Length;
        while (left < right) {
            int mid = left + ((right - left) >> 1);
            if (nums[mid] < 0) {
                left = mid + 1;
            } else {
                right = mid;
            }
        }
        return left;
    }
    
    private long GetMinProduct(int[] nums1, int[] nums2) {
        long min = long.MaxValue;
        min = Math.Min(min, (long)nums1[0] * nums2[0]);
        min = Math.Min(min, (long)nums1[0] * nums2[nums2.Length - 1]);
        min = Math.Min(min, (long)nums1[nums1.Length - 1] * nums2[0]);
        min = Math.Min(min, (long)nums1[nums1.Length - 1] * nums2[nums2.Length - 1]);
        return min;
    }
    
    private long GetMaxProduct(int[] nums1, int[] nums2) {
        long max = long.MinValue;
        max = Math.Max(max, (long)nums1[0] * nums2[0]);
        max = Math.Max(max, (long)nums1[0] * nums2[nums2.Length - 1]);
        max = Math.Max(max, (long)nums1[nums1.Length - 1] * nums2[0]);
        max = Math.Max(max, (long)nums1[nums1.Length - 1] * nums2[nums2.Length - 1]);
        return max;
    }
    
    private long CountProductsLessOrEqual(int[] nums1, int[] nums2, int pos1, int pos2, long target) {
        long count = 0;
        
        // Case 1: neg1 * neg2 - only if both arrays have negatives
        if (pos1 > 0 && pos2 > 0) {
            int i1 = 0, i2 = pos2 - 1;
            while (i1 < pos1 && i2 >= 0) {
                if ((long)nums1[i1] * nums2[i2] <= target) {
                    count += pos1 - i1;
                    i2--;
                } else {
                    i1++;
                }
            }
        }
        
        // Case 2: nonNeg1 * nonNeg2 - only if both arrays have non-negatives
        if (pos1 < nums1.Length && pos2 < nums2.Length) {
            int i1 = pos1, i2 = nums2.Length - 1;
            while (i1 < nums1.Length && i2 >= pos2) {
                if ((long)nums1[i1] * nums2[i2] <= target) {
                    count += i2 - pos2 + 1;
                    i1++;
                } else {
                    i2--;
                }
            }
        }
        
        // Case 3: neg1 * nonNeg2 - negative * non-negative
        if (pos1 > 0 && pos2 < nums2.Length) {
            int i1 = 0, i2 = pos2;
            while (i1 < pos1 && i2 < nums2.Length) {
                if ((long)nums1[i1] * nums2[i2] <= target) {
                    count += nums2.Length - i2;
                    i1++;
                } else {
                    i2++;
                }
            }
        }
        
        // Case 4: nonNeg1 * neg2 - non-negative * negative
        if (pos1 < nums1.Length && pos2 > 0) {
            int i1 = pos1, i2 = 0;
            while (i1 < nums1.Length && i2 < pos2) {
                if ((long)nums1[i1] * nums2[i2] <= target) {
                    count += nums1.Length - i1;
                    i2++;
                } else {
                    i1++;
                }
            }
        }
        
        return count;
    }
}