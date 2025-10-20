namespace LeetCodeSolutions.DataStructures/String;

/*
 * 2011. Final Value of Variable After Performing Operations
 * Difficulty: Easy
 * Submission Time: 2025-10-20 12:41:30
 * Created by vahtyah on 2025-10-20 12:42:22
*/
 
public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        var x = 0;

        foreach(var operation in operations){
            if(IsIncrease(operation)) x++;
            else x--;
        }

        return x;
    }

    public bool IsIncrease(string operation) => operation[0] == '+' || operation[^1] == '+';
}