public class Solution {
    public int WaysToSplitArray(int[] nums) {
        long totalSum = 0, leftSum = 0, rightSum = 0;
        int answer = 0;
        foreach(var num in nums) totalSum += num;

        for(int i = 0; i < nums.Length - 1; i++){
            leftSum += nums[i];
            rightSum = totalSum - leftSum;
            if(leftSum >= rightSum) answer++;
        }

        return answer;
    }
}