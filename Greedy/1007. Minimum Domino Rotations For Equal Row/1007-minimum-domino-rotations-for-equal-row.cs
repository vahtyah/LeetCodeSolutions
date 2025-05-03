namespace LeetCodeSolutions.Greedy;

/*
 * 1007. Minimum Domino Rotations For Equal Row
 * Difficulty: Medium
 * Submission Time: 2025-05-03 05:07:26
 * Created by vahtyah on 2025-05-03 05:08:52
*/
 
public class Solution {
    public int MinDominoRotations(int[] tops, int[] bottoms) {
        var result = GetRotations(tops, bottoms, tops[0]);
        if(result != -1) return result;
        
        return GetRotations(tops, bottoms, bottoms[0]);
    }

    private int GetRotations(int[] tops, int[] bottoms, int target) {
        var topRotations = 0;
        var bottomRotations = 0;
        
        for (int i = 0; i < tops.Length; i++) {
            if (tops[i] != target && bottoms[i] != target) 
                return -1;
            
            if (tops[i] != target) topRotations++;
            if (bottoms[i] != target) bottomRotations++;
        }
        
        return Math.Min(topRotations, bottomRotations);
    }
}