namespace LeetCodeSolutions.Math;

/*
 * 0812. Largest Triangle Area
 * Difficulty: Easy
 * Submission Time: 2025-09-27 08:44:43
 * Created by vahtyah on 2025-09-28 02:45:01
*/
 
public class Solution {
    public double LargestTriangleArea(int[][] points) {
        double maxArea = 0;
        
        for(int i = 0; i < points.Length - 2; i++){
            for(int j = i + 1; j < points.Length - 1; j++){
                for(int k = j + 1; k < points.Length; k++){
                    // Use cross product formula: Area = 0.5 * |x1(y2-y3) + x2(y3-y1) + x3(y1-y2)|
                    double area = Math.Abs(
                        points[i][0] * (points[j][1] - points[k][1]) +
                        points[j][0] * (points[k][1] - points[i][1]) +
                        points[k][0] * (points[i][1] - points[j][1])
                    ) * 0.5;
                    
                    if (area > maxArea) {
                        maxArea = area;
                    }
                }
            }
        }
        
        return maxArea;
    }
}