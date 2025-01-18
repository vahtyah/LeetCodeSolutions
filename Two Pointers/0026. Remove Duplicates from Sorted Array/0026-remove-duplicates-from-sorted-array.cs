public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length == 0) return 0;
        
        int insertIndex = 1;  
        
        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] != nums[insertIndex - 1]) {
                nums[insertIndex] = nums[i];
                insertIndex++;
            }
        }
        
        return insertIndex;
    }
}