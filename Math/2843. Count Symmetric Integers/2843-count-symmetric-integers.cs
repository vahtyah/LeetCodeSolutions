namespace LeetCodeSolutions.Math;

/*
 * 2843. Count Symmetric Integers
 * Difficulty: Easy
 * Submission Time: 2025-04-11 06:01:28
 * Created by vahtyah on 2025-04-11 06:01:51
*/
 
public class Solution {
    public int CountSymmetricIntegers(int lowerBound, int upperBound) {
        int symmetricCount = 0;
        
        for (int currentNumber = lowerBound; currentNumber <= upperBound; ++currentNumber) {
            if (currentNumber < 100 && currentNumber % 11 == 0) {
                symmetricCount++;
            }
            else if (1000 <= currentNumber && currentNumber < 10000) {
                int firstTwoDigitsSum = currentNumber / 1000 + (currentNumber % 1000) / 100;
                int lastTwoDigitsSum = (currentNumber % 100) / 10 + currentNumber % 10;
                
                if (firstTwoDigitsSum == lastTwoDigitsSum) {
                    symmetricCount++;
                }
            }
        }
        return symmetricCount;
    }
}