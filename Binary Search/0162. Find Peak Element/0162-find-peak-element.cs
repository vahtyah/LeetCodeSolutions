public class Solution {
    public int FindPeakElement(int[] nums) {
        int left = 0;
        int right = nums.Length - 1;
        while (left < right) { //binary search
            int mid = left + (right - left) / 2; //get mid index
            if(nums[mid] < nums[mid + 1]) { //if mid is less than mid+1, then peak is on the right
                left = mid + 1;
            }
            else { //if mid is greater than mid+1, then peak is on the left
                right = mid;
            }
        }
        
        return left; //return left or right, both are same
    }
}