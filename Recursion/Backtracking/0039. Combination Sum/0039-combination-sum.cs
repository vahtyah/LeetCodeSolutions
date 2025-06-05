namespace LeetCodeSolutions.Recursion/Backtracking;

/*
 * 0039. Combination Sum
 * Difficulty: Medium
 * Submission Time: 2025-06-05 19:53:57
 * Created by vahtyah on 2025-06-05 19:54:19
*/
 
public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        var result = new List<IList<int>>();
        Backtrack(candidates, target, 0, new List<int>(), result);
        return result;
    }
    
    private void Backtrack(int[] candidates, int target, int start, List<int> current, IList<IList<int>> result) {
        if (target == 0) {
            result.Add(new List<int>(current));
            return;
        }
        
        for (int i = start; i < candidates.Length; i++) {
            if (candidates[i] > target) {
                continue; 
            }
            
            current.Add(candidates[i]);
            Backtrack(candidates, target - candidates[i], i, current, result);
            current.RemoveAt(current.Count - 1);
        }
    }
}