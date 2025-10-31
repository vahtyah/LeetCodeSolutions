namespace LeetCodeSolutions.DataStructures/HashTable;

/*
 * 3289. The Two Sneaky Numbers of Digitville
 * Difficulty: Easy
 * Submission Time: 2025-10-31 05:35:57
 * Created by vahtyah on 2025-10-31 14:46:10
*/
 
public class Solution {
    public int[] GetSneakyNumbers(int[] nums) {
        Span<int> freq = stackalloc int[101];
        var result = new int[2];
        var index = 0;

        for(int i = 0; i < nums.Length; i++){
            freq[nums[i]]++;
        }

        for(int i = 0; i < 101; i++){
            if(freq[i] == 2) result[index++] = i;
        }

        return result;
    }
}