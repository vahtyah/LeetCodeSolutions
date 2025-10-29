namespace LeetCodeSolutions.BitManipulation;

/*
 * 3370. Smallest Number With All Set Bits
 * Difficulty: Easy
 * Submission Time: 2025-10-29 05:27:50
 * Created by vahtyah on 2025-10-29 12:51:54
*/
 
public class Solution {
    public int SmallestNumber(int n) {
        var number = 1;

        while(true){
            var powerOf2 = 1 << number++;
            if(powerOf2 > n) return powerOf2 - 1;
        }

        return 0;
    }
}