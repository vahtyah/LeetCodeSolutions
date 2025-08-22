namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 1470. Shuffle the Array
 * Difficulty: Easy
 * Submission Time: 2025-11-22 17:12:42
 * Created by vahtyah on 2025-12-11 14:55:33
*/
 
public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        var answer = new int[n * 2];

        for(int i = 0; i < n; i++){
            var index = i << 1;
            answer[index] = nums[i];
            answer[index + 1] = nums[i + n];
        }

        return answer;
    }
}