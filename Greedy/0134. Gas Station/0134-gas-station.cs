namespace LeetCodeSolutions.Greedy;

/*
 * 0134. Gas Station
 * Difficulty: Medium
 * Submission Time: 2025-01-31 13:28:57
 * Created by vahtyah on 2025-01-31 13:29:34
 */
 
public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        int totalGas = 0;
        int totalCost = 0;
        int currentGas = 0;
        int startStation = 0;
        
        for(int i = 0; i < gas.Length; i++) {
            totalGas += gas[i];
            totalCost += cost[i];
            
            currentGas += gas[i] - cost[i];
            
            if(currentGas < 0) {
                startStation = i + 1;
                currentGas = 0;
            }
        }
        
        return totalGas < totalCost ? -1 : startStation;
    }
}