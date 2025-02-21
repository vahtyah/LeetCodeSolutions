namespace LeetCodeSolutions.Searching/BinarySearch;

/*
 * 2300. Successful Pairs of Spells and Potions
 * Difficulty: Medium
 * Submission Time: 2025-01-03 19:02:52
 * Created by vahtyah on 2025-02-21 07:07:47
*/
 
//Binary Search with Time Complexity O(nlogn) and Space Complexity O(n)
public class Solution {
    private void RadixSort(int[] arr) {
        int max = arr.Max();
        
        // Do counting sort for every digit
        for (int exp = 1; max / exp > 0; exp *= 10) {
            CountingSortByDigit(arr, exp);
        }
    }
    
    private void CountingSortByDigit(int[] arr, int exp) {
        int n = arr.Length;
        int[] output = new int[n];
        int[] count = new int[10];
        
        // Store count of occurrences in count[]
        for (int i = 0; i < n; i++) {
            count[(arr[i] / exp) % 10]++;
        }
        
        // Change count[i] so that count[i] now contains
        // actual position of this digit in output[]
        for (int i = 1; i < 10; i++) {
            count[i] += count[i - 1];
        }
        
        // Build the output array
        for (int i = n - 1; i >= 0; i--) {
            output[count[(arr[i] / exp) % 10] - 1] = arr[i];
            count[(arr[i] / exp) % 10]--;
        }
        
        // Copy the output array to arr[]
        Array.Copy(output, arr, n);
    }    
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success) {
        var n = spells.Length;
        var m = potions.Length;
        int x = int.MinValue;
        var pairs = new int[n];

        RadixSort(potions);

        for(int i = 0; i < n; i++){
            var spell = spells[i];
            if(spell <= x) {
                pairs[i] = 0;
                continue;
            }
            pairs[i] = m - BinarySearch(potions, success, spell);
            if(pairs[i] == 0 && spell > x) x = spell; 
        }

        return pairs;
    }

    private int BinarySearch(int[] potions ,long success ,int spell){
        var left = 0;
        var right = potions.Length - 1;
        var target = (success + spell - 1) / spell;
        while(left <= right){
            int mid = left + (right - left) / 2;
            if(potions[mid] >= target) right = mid - 1;
            else left = mid + 1;
        }
        return left;
    }
}