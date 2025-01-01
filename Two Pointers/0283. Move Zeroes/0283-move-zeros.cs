public class Solution {
    public void MoveZeroes(int[] nums) {
        var left = 0;
        var right = 1;

        while(right < nums.Length){
            if(nums[left] != 0){
                left++;
                right++;
            }
            else{
                if(nums[right] == 0) right++;
                else{
                    nums[left] = nums[right];
                    nums[right] = 0;
                    left++;
                    right++;
                }
            }
        }
    }
}