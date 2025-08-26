namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 3000. Maximum Area of Longest Diagonal Rectangle
 * Difficulty: Easy
 * Submission Time: 2025-08-26 12:50:22
 * Created by vahtyah on 2025-08-26 12:50:55
*/
 
public class Solution {
    public int AreaOfMaxDiagonal(int[][] dimensions) {
        var sqrGreatestDiagonal = 0;
        var greatestArea = 0;

        foreach(var dimension in dimensions){
            var diagonal = dimension[0] * dimension[0] + dimension[1] * dimension[1];

            if(diagonal > sqrGreatestDiagonal){
                sqrGreatestDiagonal = diagonal;
                greatestArea = dimension[0] * dimension[1];
            }
            else if(diagonal == sqrGreatestDiagonal) greatestArea = Math.Max(dimension[0] * dimension[1], greatestArea);
        }

        return greatestArea;
    }
}