public class Solution {
    public bool IncreasingTriplet(int[] nums)
    {
        int right = nums[nums.Length - 1]; //k
        int mid = Int32.MinValue; //j
        for (int i = nums.Length - 1; i > -1; i--)
        {
            if (nums[i] >= right) right = nums[i]; // biggest
            else if (nums[i] >= mid) mid = nums[i]; // smaller than right
            else return true; //smallest
        }
        return false;
    }
}
