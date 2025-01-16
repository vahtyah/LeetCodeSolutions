public class Solution {
    public int FindMinArrowShots(int[][] points) {
        // Edge cases handling
        if (points == null || points.Length == 0) return 0;
        if (points.Length == 1) return 1;
        
        // Sort by end points
        // Using comparison delegate instead of lambda for better performance
        Array.Sort(points, CompareByEndPoint);
        
        int count = 1;  // Start with 1 arrow
        int currentEnd = points[0][1];
        
        // Iterate through remaining points
        for (int i = 1; i < points.Length; i++) {
            if (points[i][0] > currentEnd) {
                count++;
                currentEnd = points[i][1];
            }
        }
        
        return count;
    }
    
    private static int CompareByEndPoint(int[] a, int[] b) {
        // Handle potential integer overflow
        if (a[1] < b[1]) return -1;
        if (a[1] > b[1]) return 1;
        return 0;
    }
}