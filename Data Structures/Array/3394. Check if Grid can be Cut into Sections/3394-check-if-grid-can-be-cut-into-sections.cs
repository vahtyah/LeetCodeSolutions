namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 3394. Check if Grid can be Cut into Sections
 * Difficulty: Medium
 * Submission Time: 2025-03-25 05:55:42
 * Created by vahtyah on 2025-03-25 05:57:12
*/
 
public class Solution {
    public bool CheckValidCuts(int n, int[][] rectangles) {
        var m = rectangles.Length;
        var horizontal = new int[m][];
        var vertical = new int[m][];

        for(int i = 0; i < m; i++){
            horizontal[i] = [rectangles[i][0], rectangles[i][2]];
            vertical[i] = [rectangles[i][1], rectangles[i][3]];
        }

        if (CountCuts(horizontal) >= 2) return true;
        return CountCuts(vertical) >= 2;
    }

    private int CountCuts(int[][] spans) {
        Array.Sort(spans, (x, y) => x[0].CompareTo(y[0]));
        
        int cuts = 0;
        int endPos = spans[0][1];
        
        for (int i = 1; i < spans.Length; i++) {
            if (spans[i][1] <= endPos) continue;
            
            if (spans[i][0] < endPos) {
                endPos = Math.Max(endPos, spans[i][1]);
            } else {
                cuts++;
                endPos = spans[i][1];
            }
            
            if (cuts >= 2) return cuts;
        }
        
        return cuts;
    }
}