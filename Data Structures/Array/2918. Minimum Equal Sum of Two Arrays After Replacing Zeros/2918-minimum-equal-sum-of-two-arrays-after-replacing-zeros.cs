namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 2918. Minimum Equal Sum of Two Arrays After Replacing Zeros
 * Difficulty: Medium
 * Submission Time: 2025-05-10 06:30:15
 * Created by vahtyah on 2025-05-10 06:30:49
*/
 
public class Solution {
    public long MinSum(int[] nums1, int[] nums2) {
        long sum1 = 0, sum2 = 0; 
        int zeroCount1 = 0, zeroCount2 = 0;

        for(int i = 0; i < nums1.Length; i++){
            if(nums1[i] == 0){
                zeroCount1++;
                sum1++;
            }
            else sum1 += nums1[i];
        }
        for(int i = 0; i < nums2.Length; i++){
            if(nums2[i] == 0){
                zeroCount2++;
                sum2++;
            }
            else sum2 += nums2[i];
        }

        if((zeroCount1 == 0 && sum1 < sum2) || (zeroCount2 == 0 && sum2 < sum1)) return -1;

        return sum1 > sum2 ? sum1 : sum2;
    }
}