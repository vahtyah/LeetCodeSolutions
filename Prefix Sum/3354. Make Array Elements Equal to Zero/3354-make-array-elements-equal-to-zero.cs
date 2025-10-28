namespace LeetCodeSolutions.PrefixSum;

/*
 * 3354. Make Array Elements Equal to Zero
 * Difficulty: Easy
 * Submission Time: 2025-10-28 12:32:22
 * Created by vahtyah on 2025-10-28 12:33:12
*/
 
public class Solution {
    public int CountValidSelections(int[] nums) {
        var n = nums.Length;

        var prefix = new int[n];
        var postfix = new int[n];
        var zeroIndecies = new List<int>();

        prefix[0] = nums[0];
        postfix[^1] = nums[^1];
        if(nums[0] == 0) zeroIndecies.Add(0);

        for(int i = 1; i < n; i++){
            prefix[i] = prefix[i - 1] + nums[i];
            postfix[n - i - 1] = postfix[n - i] + nums[n - i - 1];
            if(nums[i] == 0) zeroIndecies.Add(i);
        }

        var result = 0;

        foreach(var idx in zeroIndecies){
            var left = GetPrefixSum(prefix, idx);
            var right = GetPostfixSum(postfix, idx);

            if(left == right) result += 2;
            if(Math.Abs(left - right) == 1) result++;
        }

        return result;
    }

    private int GetPrefixSum(int[] prefix, int index) => index == 0 ? 0 : prefix[index - 1];
    private int GetPostfixSum(int[] postfix, int index) => index == postfix.Length - 1 ? 0 : postfix[index + 1];
}