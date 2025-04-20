namespace LeetCodeSolutions.Greedy;

/*
 * 0781. Rabbits in Forest
 * Difficulty: Medium
 * Submission Time: 2025-04-20 05:22:47
 * Created by vahtyah on 2025-04-20 05:24:07
*/
 
public class Solution {
    public int NumRabbits(int[] answers) {
        var groupCounts = new int[1001]; 
        var totalRabbits = 0;

        foreach (var answer in answers) {
            if (groupCounts[answer] == answer + 1) {
                groupCounts[answer] = 0;
            }
            
            if (groupCounts[answer] == 0) {
                totalRabbits += answer + 1;
            }
            
            groupCounts[answer]++;
        }

        return totalRabbits;
    }
}