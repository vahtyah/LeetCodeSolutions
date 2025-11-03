namespace LeetCodeSolutions.Greedy;

/*
 * 1578. Minimum Time to Make Rope Colorful
 * Difficulty: Medium
 * Submission Time: 2025-11-03 05:34:11
 * Created by vahtyah on 2025-11-03 13:57:50
*/
 
public class Solution {
    public int MinCost(string colors, int[] neededTime) {
        var minCost = 0;
        
        for(int i = 1; i < colors.Length; i++){
            var curr = neededTime[i];
            var prev = neededTime[i - 1];

            if(colors[i] == colors[i - 1]){
                if(curr > prev){
                    minCost += prev;
                }
                else{
                    minCost += curr;
                    neededTime[i] = prev;
                }
            }
        }

        return minCost;
    }
}