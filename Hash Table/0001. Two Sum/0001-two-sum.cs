public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var seen = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++){
            var remaining = target - nums[i];
            if(seen.TryGetValue(remaining, out var index)){
                return new int[2]{index, i};
            }
            seen.TryAdd(nums[i], i);
        }

        return null;
    }
}