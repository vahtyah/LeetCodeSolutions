namespace LeetCodeSolutions.Searching/Breadth-FirstSearch;

/*
 * 2359. Find Closest Node to Given Two Nodes
 * Difficulty: Medium
 * Submission Time: 2025-05-30 10:49:30
 * Created by vahtyah on 2025-05-30 15:16:26
*/
 
public class Solution {
    public int ClosestMeetingNode(int[] edges, int node1, int node2) {
        int n = edges.Length;
        Span<int> dist1 = stackalloc int[n];
        Span<int> dist2 = stackalloc int[n];
        
        dist1.Fill(-1);
        dist2.Fill(-1);
        
        CalculateDistances(edges, node1, dist1);
        CalculateDistances(edges, node2, dist2);
        
        int result = -1;
        int minMaxDistance = int.MaxValue;
        
        for (int i = 0; i < n; i++) {
            if (dist1[i] >= 0 && dist2[i] >= 0) {
                int maxDist = dist1[i] > dist2[i] ? dist1[i] : dist2[i];
                if (maxDist < minMaxDistance) {
                    minMaxDistance = maxDist;
                    result = i;
                }
            }
        }
        
        return result;
    }
    
    private static void CalculateDistances(ReadOnlySpan<int> edges, int start, Span<int> distances) {
        int current = start;
        int distance = 0;
        
        while (current != -1 && distances[current] == -1) {
            distances[current] = distance++;
            current = edges[current];
        }
    }
}