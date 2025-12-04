namespace LeetCodeSolutions.DataStructures/String;

/*
 * 2211. Count Collisions on a Road
 * Difficulty: Medium
 * Submission Time: 2025-12-04 15:33:06
 * Created by vahtyah on 2025-12-04 15:37:45
*/
 
public class Solution {
    public int CountCollisions(string directions) {
        int n = directions.Length;
        if (n <= 1) return 0;
        
        int left = 0;
        while (left < n && directions[left] == 'L') {
            left++;
        }
        
        int right = n - 1;
        while (right >= 0 && directions[right] == 'R') {
            right--;
        }
        
        int result = 0;
        for (int i = left; i <= right; i++) {
            if (directions[i] != 'S') {
                result++;
            }
        }
        
        return result;
    }
}