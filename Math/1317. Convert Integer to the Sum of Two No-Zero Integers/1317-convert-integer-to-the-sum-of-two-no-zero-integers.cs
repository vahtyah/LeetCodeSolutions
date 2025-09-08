namespace LeetCodeSolutions.Math;

/*
 * 1317. Convert Integer to the Sum of Two No-Zero Integers
 * Difficulty: Easy
 * Submission Time: 2025-09-08 12:25:00
 * Created by vahtyah on 2025-09-08 12:25:31
*/
 
public class Solution {

    public int[] GetNoZeroIntegers(int n) {
        for(int i = 1; i < n; i++){
            if(IsNoZeroInterger(i) && IsNoZeroInterger(n - i)) return new int[] {i, n - i};
        }

        return new int[2];
    }

    private bool IsNoZeroInterger(int num){
        while(num > 0){
            if(num % 10 == 0) return false;
            num /= 10;
        }
        return true;
    }
}