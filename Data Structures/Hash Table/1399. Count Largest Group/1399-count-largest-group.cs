namespace LeetCodeSolutions.DataStructures/HashTable;

/*
 * 1399. Count Largest Group
 * Difficulty: Easy
 * Submission Time: 2025-04-23 05:04:32
 * Created by vahtyah on 2025-04-23 05:05:00
*/
 
public class Solution {
    private static int[] numToSumDigits = new int[10001];
    
    public int CountLargestGroup(int n) {
        var sizes = new int[37];
        var maxSize = 0;
        var maxSizeCount = 0;
        
        for (int i = 1; i <= n; i++) {
            var sumDigits = numToSumDigits[i];
            if(sumDigits == 0){
                sumDigits = SumDigits(i);
                numToSumDigits[i] = sumDigits;
            }
            
            sizes[sumDigits]++;
            
            if (sizes[sumDigits] > maxSize) {
                maxSize = sizes[sumDigits];
                maxSizeCount = 1;
            } else if (sizes[sumDigits] == maxSize) {
                maxSizeCount++;
            }
        }
        
        return maxSizeCount;
    }
    
    public int SumDigits(int num) {
        var sum = 0;
        while (num > 0) {
            sum += num % 10;
            num /= 10;
        }
        return sum;
    }
}