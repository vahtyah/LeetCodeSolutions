public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int counter = 0;
        
        for(int i = 0; i < nums.Length; i++) {
            if(nums[i] != val) {
                nums[counter] = nums[i];
                counter++;
            }
        }
        
        return counter;
    }
}