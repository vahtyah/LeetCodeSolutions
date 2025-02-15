namespace LeetCodeSolutions.Backtracking;

/*
 * 2698. Find the Punishment Number of an Integer
 * Difficulty: Medium
 * Submission Time: 2025-02-15 08:46:22
 * Created by vahtyah on 2025-02-15 08:57:03
*/
 
public class Solution {
    private static int[] PreCalculatedSums = new int[1001];

    public Solution(){
        if(PreCalculatedSums[1] == 1) return;
        for(int i = 1; i < 1001; i++){
            if(CheckSumMatch(0 ,0 , i * i, i, 0)){
                PreCalculatedSums[i] = PreCalculatedSums[i-1] + i * i;
            }
            else PreCalculatedSums[i] = PreCalculatedSums[i-1];
        }
    }

    public int PunishmentNumber(int n) {
        return PreCalculatedSums[n];
    }
    
    public bool CheckSumMatch(int sumSoFar, int currentPartialSum, int number, int targetSum, int position) {
        if(number == 0) {
            sumSoFar += currentPartialSum;
            return sumSoFar == targetSum;
        }

        if(position > 0) {
            return 
                CheckSumMatch(sumSoFar + currentPartialSum, number % 10, number / 10, targetSum, 1) ||
                CheckSumMatch(sumSoFar, currentPartialSum + (int)Math.Pow(10, position) * (number % 10), number / 10, targetSum, position + 1);
        } else {
            return CheckSumMatch(sumSoFar, number % 10, number / 10, targetSum, 1);
        }
    }
}