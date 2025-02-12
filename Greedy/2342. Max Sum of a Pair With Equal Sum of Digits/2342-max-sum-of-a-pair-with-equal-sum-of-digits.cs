namespace LeetCodeSolutions.Greedy;

/*
 * 2342. Max Sum of a Pair With Equal Sum of Digits
 * Difficulty: Medium
 * Submission Time: 2025-02-12 06:19:06
 * Created by vahtyah on 2025-02-12 06:34:44
*/
 
public class Solution {
    public int MaximumSum(int[] nums) {
        var sumDigits = new int[82];
        var answer = -1;
        for(var i = 0; i < nums.Length; i++){
            var num = nums[i];
            var sum = 0;
            while(num > 0){
                sum += num % 10;
                num /= 10;
            }
            if(sumDigits[sum] != 0) answer = Math.Max(answer, sumDigits[sum] + nums[i]);
            sumDigits[sum] = Math.Max(sumDigits[sum], nums[i]);
        }

        return answer;
    }
}