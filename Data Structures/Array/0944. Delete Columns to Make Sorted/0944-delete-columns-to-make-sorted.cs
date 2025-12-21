namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 0944. Delete Columns to Make Sorted
 * Difficulty: Easy
 * Submission Time: 2025-12-20 08:05:58
 * Created by vahtyah on 2025-12-21 12:31:46
*/
 
public class Solution {
    public int MinDeletionSize(string[] strs) {
        var result = 0;

        for(int i = 0; i < strs[0].Length; i++){
            for(int j = 1; j < strs.Length; j++){
                if(strs[j][i] >= strs[j - 1][i]) continue;
                result++;
                break;
            }
        }

        return result;
    }
}