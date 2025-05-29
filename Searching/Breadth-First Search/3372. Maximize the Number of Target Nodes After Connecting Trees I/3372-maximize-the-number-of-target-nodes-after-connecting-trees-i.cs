namespace LeetCodeSolutions.Searching/Breadth-FirstSearch;

/*
 * 3372. Maximize the Number of Target Nodes After Connecting Trees I
 * Difficulty: Medium
 * Submission Time: 2025-05-29 06:36:40
 * Created by vahtyah on 2025-05-29 06:37:11
*/
 
public class Solution {
    public int[] MaxTargetNodes(int[][] edges1, int[][] edges2, int k) {
        int n = edges1.Length + 1; 
        int m = edges2.Length + 1; 
        
        var graph1 = BuildGraph(edges1, n);
        var graph2 = BuildGraph(edges2, m);
        
        int maxTree2Targets = 0;
        for (int i = 0; i < m; i++) {
            maxTree2Targets = Math.Max(maxTree2Targets, CountTargets(graph2, i, k - 1));
        }

        var result = new int[n];
        for (int i = 0; i < n; i++) {
            result[i] = CountTargets(graph1, i, k) + maxTree2Targets;
        }
        
        return result;
    }
    
    private List<int>[] BuildGraph(int[][] edges, int nodeCount) {
        var graph = new List<int>[nodeCount];
        for (int i = 0; i < nodeCount; i++) {
            graph[i] = new List<int>();
        }
        
        foreach (var edge in edges) {
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }
        
        return graph;
    }
    
    private int CountTargets(List<int>[] graph, int start, int maxDist) {
        if (maxDist < 0) return 0;
        
        var visited = new bool[graph.Length];
        var queue = new Queue<(int node, int dist)>();
        
        queue.Enqueue((start, 0));
        visited[start] = true;
        int count = 0;
        
        while (queue.Count > 0) {
            var (currentNode, currentDist) = queue.Dequeue();
            count++;
            
            if (currentDist < maxDist) {
                foreach (int neighbor in graph[currentNode]) {
                    if (!visited[neighbor]) {
                        visited[neighbor] = true;
                        queue.Enqueue((neighbor, currentDist + 1));
                    }
                }
            }
        }
        
        return count;
    }
}