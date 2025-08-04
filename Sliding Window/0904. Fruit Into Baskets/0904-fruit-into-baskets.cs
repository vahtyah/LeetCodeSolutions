namespace LeetCodeSolutions.SlidingWindow;

/*
 * 0904. Fruit Into Baskets
 * Difficulty: Medium
 * Submission Time: 2025-08-04 06:32:46
 * Created by vahtyah on 2025-08-04 06:33:50
*/
 
public class Solution {
    public int TotalFruit(int[] fruits) {
        int currentFruit = fruits[0];
        int previousFruit = -1;
        
        int consecutiveCurrentCount = 1;
        int totalValidWindowLength = 1;
        
        int maxValidWindowLength = 1;
        
        for (int i = 1; i < fruits.Length; i++)
        {   
            if (fruits[i] == currentFruit)
            {
                consecutiveCurrentCount++;
                totalValidWindowLength++;
            }
            else if (previousFruit == -1 || fruits[i] == previousFruit)
            {
                previousFruit = currentFruit;
                currentFruit = fruits[i];
                consecutiveCurrentCount = 1;
                totalValidWindowLength++;
            }
            else 
            {
                maxValidWindowLength = Math.Max(maxValidWindowLength, totalValidWindowLength);
                previousFruit = currentFruit;
                currentFruit = fruits[i];
                totalValidWindowLength = consecutiveCurrentCount + 1;
                consecutiveCurrentCount = 1;
            }
        }
        
        maxValidWindowLength = Math.Max(maxValidWindowLength, totalValidWindowLength);
        
        return maxValidWindowLength;
    }
}


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