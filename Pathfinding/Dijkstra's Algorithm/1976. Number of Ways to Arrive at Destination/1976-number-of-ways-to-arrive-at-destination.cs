namespace LeetCodeSolutions.Pathfinding/Dijkstra'sAlgorithm;

/*
 * 1976. Number of Ways to Arrive at Destination
 * Difficulty: Medium
 * Submission Time: 2025-03-23 04:48:02
 * Created by vahtyah on 2025-03-23 04:48:28
*/
 
public class Solution {
    public int CountPaths(int n, int[][] roads) {
        const int MOD = 1_000_000_007;
        var graph = new List<(long node, long time)>[n];
        for (int i = 0; i < n; i++) {
            graph[i] = new List<(long node, long time)>();
        }
        
        // Build adjacency list
        foreach (var road in roads) {
            graph[road[0]].Add((road[1], road[2]));
            graph[road[1]].Add((road[0], road[2]));
        }
        
        // Array to store minimum time to reach each node
        var minTime = new long[n];
        Array.Fill(minTime, long.MaxValue);
        minTime[0] = 0;
        
        // Array to store number of ways to reach each node with minimum time
        var ways = new long[n];
        ways[0] = 1;
        
        // Priority queue to store (time, node)
        var pq = new PriorityQueue<(long node, long time), long>();
        pq.Enqueue((0, 0), 0);
        
        while (pq.Count > 0) {
            var (curr, time) = pq.Dequeue();
            
            // Skip if we've found a better path
            if (time > minTime[curr]) continue;
            
            // Check all neighbors
            foreach (var (next, t) in graph[curr]) {
                long newTime = time + t;
                
                // If we found a shorter path
                if (newTime < minTime[next]) {
                    minTime[next] = newTime;
                    ways[next] = ways[curr];
                    pq.Enqueue((next, newTime), newTime);
                }
                // If we found another path with the same minimum time
                else if (newTime == minTime[next]) {
                    ways[next] = (ways[next] + ways[curr]) % MOD;
                }
            }
        }
        
        return (int)ways[n - 1];
    }
}