namespace LeetCodeSolutions.SlidingWindow;

/*
 * 0904. Fruit Into Baskets
 * Difficulty: Medium
 * Submission Time: 2025-08-04 06:20:52
 * Created by vahtyah on 2025-08-04 06:22:47
*/
 
public class Solution {
    public int TotalFruit(int[] fruits) {
        var n = fruits.Length;

        Span<int> freq = stackalloc int[n];
        var types = 0;
        var maxFruits = 0;
        var maxFruitsSoFar = 0;

        for(int left = 0, right = 0; right < n; right++){
            if(freq[fruits[right]] == 0) types++;
            freq[fruits[right]]++;
            maxFruitsSoFar++;
            while(left < n && types > 2){
                freq[fruits[left]]--;
                if(freq[fruits[left]] == 0) types--;
                left++;
                maxFruitsSoFar--;
            }
            maxFruits = Math.Max(maxFruits, maxFruitsSoFar);
        }

        return maxFruits;
    }
}