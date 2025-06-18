namespace LeetCodeSolutions.Searching/BinarySearch;

/*
 * 0004. Median of Two Sorted Arrays
 * Difficulty: Hard
 * Submission Time: 2025-06-18 06:40:48
 * Created by vahtyah on 2025-06-18 06:41:23
*/
 
using System.Runtime.CompilerServices;

public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        if (nums1.Length > nums2.Length) return FindMedianSortedArrays(nums2, nums1);

        int m = nums1.Length;
        int n = nums2.Length;
        int totalLength = m + n;
        int halfLength = (totalLength + 1) >> 1;

        int low = 0, high = m;

        while (low <= high)
        {
            int partition1 = (low + high) >> 1;
            int partition2 = halfLength - partition1;

            int maxLeft1 = GetMaxLeft(nums1, partition1);
            int minRight1 = GetMinRight(nums1, partition1, m);
            int maxLeft2 = GetMaxLeft(nums2, partition2);
            int minRight2 = GetMinRight(nums2, partition2, n);

            if (maxLeft1 <= minRight2 && maxLeft2 <= minRight1) return CalculateMedian(totalLength, maxLeft1, maxLeft2, minRight1, minRight2);
            else if (maxLeft1 > minRight2) high = partition1 - 1;
            else low = partition1 + 1;
        }

        throw new ArgumentException("Invalid input arrays");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int GetMaxLeft(int[] array, int partition)
    {
        return partition == 0 ? int.MinValue : array[partition - 1];
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int GetMinRight(int[] array, int partition, int length)
    {
        return partition == length ? int.MaxValue : array[partition];
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static double CalculateMedian(int totalLength, int maxLeft1, int maxLeft2, int minRight1, int minRight2)
    {
        if ((totalLength & 1) == 1) 
        {
            return Math.Max(maxLeft1, maxLeft2);
        }
        else
        {
            long leftMax = Math.Max(maxLeft1, maxLeft2);
            long rightMin = Math.Min(minRight1, minRight2);
            return (leftMax + rightMin) * 0.5;
        }
    }
}