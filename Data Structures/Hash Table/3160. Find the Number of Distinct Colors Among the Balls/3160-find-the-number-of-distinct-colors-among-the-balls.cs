namespace LeetCodeSolutions.DataStructures/HashTable;

/*
 * 3160. Find the Number of Distinct Colors Among the Balls
 * Difficulty: Medium
 * Submission Time: 2025-02-07 04:24:29
 * Created by vahtyah on 2025-02-07 04:26:13
*/
 
public class Solution {
    public int[] QueryResults(int limit, int[][] queries) {
        var result = new int[queries.Length];
        var ballColor = new Dictionary<int, int>(queries.Length);
        var colorCount = new Dictionary<int, int>(queries.Length);
        for(int i = 0; i < queries.Length; i++) {
            var q = queries[i];
            int ball = q[0], newColor = q[1], prevColor = ballColor.GetValueOrDefault(ball);
            if(prevColor > 0 && --colorCount[prevColor] == 0) colorCount.Remove(prevColor);
            ballColor[ball] = newColor;
            colorCount[newColor] = colorCount.GetValueOrDefault(newColor) + 1;
            result[i] = colorCount.Count;
        }
        return result;
    }
}