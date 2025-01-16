public class Solution {
    public int XorAllNums(int[] nums1, int[] nums2) {
        var m = nums1.Length;
        var n = nums2.Length;
        if((n & 1) == 0 && (m & 1) == 0) return 0;
        var answer = 0;
        if((m & 1) == 1){
            for(int i = 0; i < n; i++){
                answer ^= nums2[i];
            }
        }
        if((n & 1) == 1){
            for(int i = 0; i < m; i++){
                answer ^= nums1[i];
            }
        }

        return answer;
    }
}