namespace LeetCodeSolutions.TwoPointers;

/*
 * 0202. Happy Number
 * Difficulty: Easy
 * Submission Time: 2025-02-07 18:25:41
 * Created by vahtyah on 2025-02-07 18:26:01
*/
 
public class Solution {
    public bool IsHappy(int n) {
        // Using Floyd's Cycle-Finding Algorithm (Two Pointers technique)
        int slow = n;
        int fast = n;
        
        do {
            slow = GetSquareSum(slow); // Move one step
            fast = GetSquareSum(GetSquareSum(fast)); // Move two steps
        } while (slow != fast);
        
        // If we found 1, it's a happy number
        return slow == 1;
    }
    
    private int GetSquareSum(int num) {
        int sum = 0;
        while (num > 0) {
            int digit = num % 10;
            sum += digit * digit;
            num /= 10;
        }
        return sum;
    }
}

public class Solution {
    public bool IsHappy(int n) {
        var seen = new HashSet<int>();
        while(n != 1 && !seen.Contains(n)){
            seen.Add(n);

            var sum = 0;

            while(n > 0){
                int digit = n % 10;
                sum += digit * digit;
                n /= 10;
            }

            n = sum;
        }

        return n == 1;
    }
}