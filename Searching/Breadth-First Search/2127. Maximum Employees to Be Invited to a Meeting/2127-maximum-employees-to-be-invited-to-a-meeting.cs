namespace LeetCodeSolutions.Searching/Breadth-FirstSearch;

/*
 * 2127. Maximum Employees to Be Invited to a Meeting
 * Difficulty: Hard
 * Created by vahtyah on 2025-01-26 08:12:04
 */
 
public class Solution {
    public int MaximumInvitations(int[] favorite) {
        int n = favorite.Length;
        
        // Build graph and calculate in-degrees
        var inDegree = new int[n];
        for (int i = 0; i < n; i++) {
            inDegree[favorite[i]]++;
        }
        
        // Step 1: Handle nodes not in cycles using topological sort
        var maxLength = new int[n];
        var queue = new Queue<int>();
        var visited = new bool[n];
        
        // Find starting nodes (in-degree = 0)
        for (int i = 0; i < n; i++) {
            if (inDegree[i] == 0) {
                queue.Enqueue(i);
                visited[i] = true;
            }
        }
        
        // Process nodes not in cycles
        while (queue.Count > 0) {
            int curr = queue.Dequeue();
            int next = favorite[curr];
            
            maxLength[next] = Math.Max(maxLength[next], maxLength[curr] + 1);
            inDegree[next]--;
            
            if (inDegree[next] == 0) {
                queue.Enqueue(next);
                visited[next] = true;
            }
        }
        
        // Step 2: Find and process cycles
        int maxCycleSize = 0;    // For case 1: single large cycle
        int sumPairs = 0;        // For case 2: sum of pairs with extensions
        
        for (int i = 0; i < n; i++) {
            if (!visited[i]) {
                var cycle = new List<int>();
                int curr = i;
                
                // Find the cycle
                while (!visited[curr]) {
                    visited[curr] = true;
                    cycle.Add(curr);
                    curr = favorite[curr];
                }
                
                // Find where the cycle starts
                int cycleStart = curr;
                int cycleStartIndex = cycle.IndexOf(cycleStart);
                
                if (cycleStartIndex == -1) continue;
                
                int cycleLength = cycle.Count - cycleStartIndex;
                
                if (cycleLength == 2) {
                    // For mutual pairs, add their extensions
                    int node1 = cycle[cycleStartIndex];
                    int node2 = favorite[node1];
                    sumPairs += 2 + maxLength[node1] + maxLength[node2];
                } else {
                    // For larger cycles, update max cycle size
                    maxCycleSize = Math.Max(maxCycleSize, cycleLength);
                }
            }
        }
        
        // Return the maximum between the two cases
        return Math.Max(maxCycleSize, sumPairs);
    }
}