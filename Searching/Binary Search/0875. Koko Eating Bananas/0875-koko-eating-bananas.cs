namespace LeetCodeSolutions.Searching/BinarySearch;

/*
 * 0875. Koko Eating Bananas
 * Difficulty: Medium
 * Submission Time: 2025-01-04 16:19:32
 * Created by vahtyah on 2025-02-21 07:06:37
*/
 
// Time Complexity: O(n * log(max(piles)))

public class Solution {
    private bool CheckEqual(int[] piles, int h, int k) { //check if eating speed k is enough to eat all bananas in h hours
        if ((long)piles.Length > h) return false; //if number of piles is greater than hours, then it is impossible to eat all bananas
        
        long hours = 0;
        unsafe { //unsafe code to improve performance
            fixed (int* p = piles) { //get pointer to piles
                for (int i = 0; i < piles.Length && hours <= h; i++) { //iterate over piles
                    hours += (p[i] + k - 1) / k;
                }
            }
        }
        return hours <= h; //return if hours is less than or equal to h
    }

    public int MinEatingSpeed(int[] piles, int h) {
        if (piles == null || piles.Length == 0) return 0; //if piles is null or empty, return 0
        if (piles.Length == 1) return (piles[0] + h - 1) / h; //if only one pile, return ceil(piles[0] / h)

        long sum = 0; //sum of all piles
        int max = 0; //maximum number of bananas in a pile
        unsafe { //unsafe code to improve performance
            fixed (int* p = piles) { //get pointer to piles
                for (int i = 0; i < piles.Length; i++) { //iterate over piles
                    sum += p[i]; //add number of bananas in pile to sum
                    max = Math.Max(max, p[i]); //get maximum number of bananas in a pile
                }
            }
        }

        int left = Math.Max(1, (int)((sum + h - 1) / h)); //minimum eating speed
        int right = Math.Min(max, (int)((sum - piles.Length + 1) / (h - piles.Length + 1) + 1)); //maximum eating speed

        if (right - left <= 1) { //if right - left is less than or equal to 1
            return CheckEqual(piles, h, left) ? left : right; //return left if left is enough to eat all bananas in h hours, otherwise return right
        }

        while (right - left > 1) { //binary search
            int mid = left + ((right - left) >> 1); //get mid index
            if (CheckEqual(piles, h, mid)) { //if eating speed mid is enough to eat all bananas in h hours
                right = mid; 
            } else { //if eating speed mid is not enough to eat all bananas in h hours
                left = mid; 
            }
        }

        return CheckEqual(piles, h, left) ? left : right; //return left if left is enough to eat all bananas in h hours, otherwise return right
    }
}

//Simpler
// Time Complexity: O(n * log(max(piles)))
public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int max = 0;
        foreach(var pile in piles) {
            max = Math.Max(max, pile);
        }
        var left = 1;
        var right = max;

        while(left < right){
            var mid = left + (right - left) / 2;
            long hours = 0;
            foreach(int pile in piles){
                hours += (pile + mid - 1) / mid;
                if(hours > h) break;
            }
            if(hours > h) left = mid + 1;
            else right = mid;
        }

        return left;
    }
}
