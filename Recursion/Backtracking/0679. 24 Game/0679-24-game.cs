namespace LeetCodeSolutions.Recursion/Backtracking;

/*
 * 0679. 24 Game
 * Difficulty: Hard
 * Submission Time: 2025-08-18 14:55:25
 * Created by vahtyah on 2025-08-18 14:56:07
*/
 
public class Solution {
    public bool JudgePoint24(int[] cards) {
        var newList = cards.Select(k => (double)k).ToList();
        return this.Backtrack(newList);
    }

    private bool Backtrack(List<double> list) {
        if (list.Count == 1) {
            return Math.Abs(list[0] - 24) <= 0.1;
        }
        
        for (var i=0;i<list.Count;i++) {
            for (var j=i+1;j<list.Count;j++) {
                var newList = new List<double>();
                for (var k=0;k<list.Count;k++) {
                    if (k == i || k == j) continue;
                    newList.Add(list[k]);                    
                }

                foreach (var combination in this.GenerateCombinations(list[i], list[j])) {
                    newList.Add(combination);
                    if (this.Backtrack(newList)) return true;
                    newList.RemoveAt(newList.Count-1);
                }
            }
        }

        return false;
    }

    private List<double> GenerateCombinations(double a, double b) {
        var result = new List<double>();
        result.Add(a+b);
        result.Add(a-b);
        result.Add(b-a);
        result.Add(a*b);
        if (b != 0) result.Add(a/b);
        if (a != 0) result.Add(b/a);
        return result;
    }
}