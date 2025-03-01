namespace LeetCodeSolutions.Recursion/Backtracking;

/*
 * 1718. Construct the Lexicographically Largest Valid Sequence
 * Difficulty: Medium
 * Submission Time: 2025-02-16 07:30:01
 * Created by vahtyah on 2025-03-01 08:27:35
*/
 
public class Solution {
    public int[] ConstructDistancedSequence(int n) {
        var result = new int[2 * n - 1];
        var used = new bool[n + 1];
        Backtrack(0, result, used, n);
        return result;
    }
    
    private bool Backtrack(int index, int[] result, bool[] used, int n) {
        if (index == result.Length) {
            return true;
        }
        
        if (result[index] != 0) {
            return Backtrack(index + 1, result, used, n);
        }
        
        for (int num = n; num > 0; num--) {
            if (used[num]) continue;
            
            if (num > 1 && (index + num >= result.Length || result[index + num] != 0)) {
                continue;
            }
            
            used[num] = true;
            result[index] = num;
            if (num > 1) {
                result[index + num] = num; 
            }
            
            if (Backtrack(index + 1, result, used, n)) {
                return true;
            }
            
            used[num] = false;
            result[index] = 0;
            if (num > 1) {
                result[index + num] = 0;
            }
        }
        
        return false;
    }
}