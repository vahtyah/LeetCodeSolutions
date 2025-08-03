namespace LeetCodeSolutions.SlidingWindow;

/*
 * 2106. Maximum Fruits Harvested After at Most K Steps
 * Difficulty: Hard
 * Submission Time: 2025-08-03 02:42:34
 * Created by vahtyah on 2025-08-03 02:43:19
*/
 
public class Solution {
    public int MaxTotalFruits(int[][] fruits, int startPos, int k) {
        int n = fruits.Length;
        int maxFruits = 0;
        int sum = 0;
        int left = 0;
        
        for (int right = 0; right < n; right++) {
            sum += fruits[right][1];
            
            // Ensure that we can collect all fruits from left to right within k steps
            while (left <= right && !IsReachable(fruits[left][0], fruits[right][0], startPos, k)) {
                sum -= fruits[left][1];
                left++;
            }
            
            maxFruits = Math.Max(maxFruits, sum);
        }
        
        return maxFruits;
    }
    
    private bool IsReachable(int leftPos, int rightPos, int startPos, int k) {
        // Case 1: startPos <= leftPos <= rightPos
        if (startPos <= leftPos) {
            return rightPos - startPos <= k;
        }
        
        // Case 2: leftPos <= rightPos <= startPos
        if (startPos >= rightPos) {
            return startPos - leftPos <= k;
        }
        
        // Case 3: leftPos < startPos < rightPos
        // Option 1: Go right first, then left
        int option1 = (rightPos - startPos) * 2 + (startPos - leftPos);
        // Option 2: Go left first, then right
        int option2 = (startPos - leftPos) * 2 + (rightPos - startPos);
        
        return Math.Min(option1, option2) <= k;
    }
}