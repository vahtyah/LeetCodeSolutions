namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 1534. Count Good Triplets
 * Difficulty: Easy
 * Submission Time: 2025-04-14 06:11:21
 * Created by vahtyah on 2025-04-14 06:12:53
*/
 
public class Solution {
    public int CountGoodTriplets(int[] arr, int a, int b, int c) {
        var goodTripletCount = 0;
        
        for(int i = 0; i < arr.Length - 2; i++){
            for(int j = i + 1; j < arr.Length - 1; j++){
                if(Math.Abs(arr[i] - arr[j]) > a) continue;
                for(int k = j + 1; k < arr.Length; k++){
                    if(Math.Abs(arr[j] - arr[k]) > b || Math.Abs(arr[i] - arr[k]) > c) continue;
                    goodTripletCount++;
                }
            }
        }

        return goodTripletCount;
    }
}