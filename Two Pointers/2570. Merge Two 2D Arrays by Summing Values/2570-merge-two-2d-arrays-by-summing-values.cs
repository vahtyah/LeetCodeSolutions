namespace LeetCodeSolutions.TwoPointers;

/*
 * 2570. Merge Two 2D Arrays by Summing Values
 * Difficulty: Easy
 * Submission Time: 2025-03-02 04:50:26
 * Created by vahtyah on 2025-03-02 04:50:51
*/
 
public class Solution {
    public int[][] MergeArrays(int[][] nums1, int[][] nums2) {
        var result = new int[nums1.Length + nums2.Length][];
        var resultIndex = 0;
        var idx1 = 0;
        var idx2 = 0;
        
        while (idx1 < nums1.Length && idx2 < nums2.Length) {
            int id1 = nums1[idx1][0];
            int id2 = nums2[idx2][0];
            
            if (id1 < id2) {
                result[resultIndex++] = nums1[idx1++];
            }
            else if (id1 > id2) {
                result[resultIndex++] = nums2[idx2++];
            }
            else {
                result[resultIndex++] = new int[] { 
                    id1, 
                    nums1[idx1++][1] + nums2[idx2++][1] 
                };
            }
        }

        while (idx1 < nums1.Length) {
            result[resultIndex++] = nums1[idx1++];
        }

        while (idx2 < nums2.Length) {
            result[resultIndex++] = nums2[idx2++];
        }

        if (resultIndex < result.Length) {
            Array.Resize(ref result, resultIndex);
        }

        return result;
    }
}