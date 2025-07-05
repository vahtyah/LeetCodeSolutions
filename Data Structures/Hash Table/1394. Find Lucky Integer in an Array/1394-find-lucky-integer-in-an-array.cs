namespace LeetCodeSolutions.DataStructures/HashTable;

/*
 * 1394. Find Lucky Integer in an Array
 * Difficulty: Easy
 * Submission Time: 2025-07-05 06:37:22
 * Created by vahtyah on 2025-07-05 07:01:24
*/
 
public class Solution {
    public int FindLucky(int[] arr) {
        var freq = new int[501];

        foreach(var num in arr) freq[num]++;

        for(int i = 500; i > 0; i--){
            if(freq[i] == i) return i;
        }

        return -1;
    }
}