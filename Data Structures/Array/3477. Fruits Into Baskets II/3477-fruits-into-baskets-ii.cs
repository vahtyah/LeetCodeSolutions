namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 3477. Fruits Into Baskets II
 * Difficulty: Easy
 * Submission Time: 2025-08-05 08:07:14
 * Created by vahtyah on 2025-08-05 08:07:54
*/
 
public class Solution {
    public int NumOfUnplacedFruits(int[] fruits, int[] baskets) {
        int count = 0;
        int n = baskets.Length;
        foreach (int fruit in fruits) {
            int unset = 1;
            for (int i = 0; i < n; i++) {
                if (fruit <= baskets[i]) {
                    baskets[i] = 0;
                    unset = 0;
                    break;
                }
            }
            count += unset;
        }
        return count;
    }
}