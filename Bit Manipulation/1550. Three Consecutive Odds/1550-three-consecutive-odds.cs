namespace LeetCodeSolutions.BitManipulation;

/*
 * 1550. Three Consecutive Odds
 * Difficulty: Easy
 * Submission Time: 2025-05-11 06:52:07
 * Created by vahtyah on 2025-05-11 06:53:41
*/
 
public class Solution {
    public bool ThreeConsecutiveOdds(int[] arr) {
        if(arr.Length < 3) return false;

        for(int i = 1; i < arr.Length - 1; i++){
            if((arr[i - 1] & 1) == 1 && (arr[i] & 1) == 1 && (arr[i + 1] & 1) == 1) return true;
        }
        
        return false;
    }
}