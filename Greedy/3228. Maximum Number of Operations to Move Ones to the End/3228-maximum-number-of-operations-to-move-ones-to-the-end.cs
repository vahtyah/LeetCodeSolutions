namespace LeetCodeSolutions.Greedy;

/*
 * 3228. Maximum Number of Operations to Move Ones to the End
 * Difficulty: Medium
 * Submission Time: 2025-11-13 05:32:54
 * Created by vahtyah on 2025-11-13 14:23:24
*/
 
public class Solution {
    public int MaxOperations(string s) {
        var curIncrease = 0;
        var operations = 0;

        for(int i = s.Length - 1; i >= 0; i--){
            if(s[i] == '1'){
                operations += curIncrease;
            }
            else{
                curIncrease++;
                while(i - 1 >= 0 && s[i - 1] != '1'){
                    i--;
                }
            }
        }

        return operations;
    }
}