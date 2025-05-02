namespace LeetCodeSolutions.TwoPointers;

/*
 * 0838. Push Dominoes
 * Difficulty: Medium
 * Submission Time: 2025-05-02 07:09:57
 * Created by vahtyah on 2025-05-02 07:10:17
*/
 
public class Solution {
    public string PushDominoes(string dominoes) {
        var s = 'L' + dominoes + 'R';
        var result = s.ToCharArray();

        for(int left = 0, right = 1; right < result.Length; right++){
            if(result[right] == '.') continue;

            if(result[left] == result[right]){
                for(int k = left + 1; k < right; k++) result[k] = result[left];
            }
            else if(result[left] == 'R' && result[right] == 'L'){
                var middle = right - left - 1;
                for(int k = 1; k <= middle / 2; k++){
                    result[left + k] = 'R';
                    result[right - k] = 'L';
                }
            }

            left = right;
        }

        return new string(result, 1, result.Length - 2);
    }
}