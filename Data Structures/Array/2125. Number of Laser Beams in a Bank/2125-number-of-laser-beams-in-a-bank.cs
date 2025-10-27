namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 2125. Number of Laser Beams in a Bank
 * Difficulty: Medium
 * Submission Time: 2025-10-27 12:58:04
 * Created by vahtyah on 2025-10-27 12:58:32
*/
 
public class Solution {
    public int NumberOfBeams(string[] bank) {
        var previousCount = 0;
        var result = 0;

        for(int i = 0; i < bank.Length; i++){
            var currentCount = 0;
            foreach(var c in bank[i]){
                currentCount += c & 1;
            }

            if(currentCount != 0){
                result += currentCount * previousCount;
                previousCount = currentCount;
            }
        }

        return result;
    }
}