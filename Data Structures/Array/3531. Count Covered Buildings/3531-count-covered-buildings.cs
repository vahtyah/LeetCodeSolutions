namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 3531. Count Covered Buildings
 * Difficulty: Medium
 * Submission Time: 2025-12-11 13:30:29
 * Created by vahtyah on 2025-12-11 14:50:56
*/
 
public class Solution {
    public int CountCoveredBuildings(int n, int[][] buildings) {
        Span<int> minYs = stackalloc int[n + 1];
        Span<int> maxYs = stackalloc int[n + 1];
        Span<int> minXs = stackalloc int[n + 1];
        Span<int> maxXs = stackalloc int[n + 1];

        for(int i = 0; i <= n; i++){
            minYs[i] = n + 1;
            minXs[i] = n + 1;
        }

        foreach(var building in buildings){
            int x = building[0], y = building[1];

            minYs[y] = Math.Min(minYs[y], x);
            maxYs[y] = Math.Max(maxYs[y], x);

            minXs[x] = Math.Min(minXs[x], y);
            maxXs[x] = Math.Max(maxXs[x], y);
        }

        int result = 0;

        foreach(var building in buildings){
            int x = building[0], y = building[1];

            if(x > minYs[y] && x < maxYs[y] &&
               y > minXs[x] && y < maxXs[x])
                result++;
        }

        return result;
    }
}
