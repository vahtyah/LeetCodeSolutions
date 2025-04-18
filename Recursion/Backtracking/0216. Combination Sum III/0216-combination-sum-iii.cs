namespace LeetCodeSolutions.Recursion/Backtracking;

/*
 * 0216. Combination Sum III
 * Difficulty: Medium
 * Submission Time: 2025-01-10 19:33:58
 * Created by vahtyah on 2025-03-01 08:24:22
*/
 
public class Solution {
    public IList<IList<int>> CombinationSum3(int k, int n) {
        List<IList<int>> result = new List<IList<int>>();
        Backtrack(result, new List<int>(), k, n, 1);
        return result;
    }
    
    private void Backtrack(List<IList<int>> result, List<int> current, int k, int remainingSum, int start) {
        if (current.Count == k && remainingSum == 0) {
            result.Add(new List<int>(current));
            return;
        }
        
        if (current.Count > k || remainingSum < 0) {
            return;
        }
        
        for (int i = start; i <= 9; i++) {
            current.Add(i);
            Backtrack(result, current, k, remainingSum - i, i + 1);
            current.RemoveAt(current.Count - 1);
        }
    }
}