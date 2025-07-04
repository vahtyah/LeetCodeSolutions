namespace LeetCodeSolutions.Searching/BinarySearch;

/*
 * 0069. Sqrt(x)
 * Difficulty: Easy
 * Submission Time: 2025-07-04 17:17:20
 * Created by vahtyah on 2025-07-04 17:48:12
*/
 
public class Solution {
    public int MySqrt(int x) {
        if (x < 2) return x;
        
        int left = 1, right = x / 2;
        int ans = 0;

        while (left <= right) {
            int mid = left + (right - left) / 2;
            long square = (long)mid * mid;
            if (square == x) return mid;
            if (square < x) {
                ans = mid;
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }
        return ans;
    }
}