namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 3074. Apple Redistribution into Boxes
 * Difficulty: Easy
 * Submission Time: 2025-12-24 16:10:01
 * Created by vahtyah on 2025-12-24 16:11:22
*/
 
public class Solution {
    public int MinimumBoxes(int[] apples, int[] capacity) {
        var sum = 0;
        
        foreach(var apple in apples){
            sum += apple;
        }

        Array.Sort(capacity, (x, y) => y.CompareTo(x));

        var result = 0;

        foreach(var c in capacity){
            sum -= c;
            result++;
            if(sum <= 0) return result;
        }

        return 0;
    }
}