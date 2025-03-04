namespace LeetCodeSolutions.Math;

/*
 * 1780. Check if Number is a Sum of Powers of Three
 * Difficulty: Medium
 * Submission Time: 2025-03-04 04:08:57
 * Created by vahtyah on 2025-03-04 04:21:04
*/
 
public class Solution {
    public bool CheckPowersOfThree(int n) {
        while(n != 0){
            if(n % 3 == 2) return false;
            n /= 3;
        }
        return true;
    }
}