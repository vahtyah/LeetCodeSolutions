namespace LeetCodeSolutions.Searching/Breadth-FirstSearch;

/*
 * 3373. Maximize the Number of Target Nodes After Connecting Trees II
 * Difficulty: Hard
 * Submission Time: 2025-05-29 06:32:04
 * Created by vahtyah on 2025-05-29 06:32:43
*/
 
public class Solution {
    public int[] MaxTargetNodes(int[][] edges1, int[][] edges2) {
        var n = edges1.Length + 1;
        var m = edges2.Length + 1;

        var graph1 = BuildGraph(edges1, n);
        var graph2 = BuildGraph(edges2, m);
        
        var maxTree2Targets = GetMaxBipartitionCounts(graph2);

        var bipartition1 = GetBipartition(graph1);
        var (evenCount1, oddCount1) = CountBipartitions(bipartition1);

        var result = new int[n];
        for (int i = 0; i < n; i++) {
            var reachableInTree1 = bipartition1[i] ? evenCount1 : oddCount1;
            result[i] = reachableInTree1 + maxTree2Targets;
        }
        return result;
    }

    private List<int>[] BuildGraph(int[][] edges, int nodeCount){
        var graph = new List<int>[nodeCount];
        for(int i = 0; i < nodeCount; i++) graph[i] = new List<int>();

        foreach(var edge in edges){
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }

        return graph;
    }

    private int GetMaxBipartitionCounts(List<int>[] graph) {
        var bipartition = GetBipartition(graph);
        var (evenCount, oddCount) = CountBipartitions(bipartition);
        return Math.Max(evenCount, oddCount);
    }

    private bool[] GetBipartition(List<int>[] graph){
        var visited = new bool[graph.Length];
        var bipartition = new bool[graph.Length];
        var queue = new Queue<int>();
        
        queue.Enqueue(0);
        visited[0] = true;
        bipartition[0] = true;
        
        while (queue.Count > 0) {
            var current = queue.Dequeue();
            
            foreach (var neighbor in graph[current]) {
                if (visited[neighbor]) continue;
                
                visited[neighbor] = true;
                bipartition[neighbor] = !bipartition[current];
                queue.Enqueue(neighbor);
            }
        }

        return bipartition;
    }

    private (int evenCount, int oddCount) CountBipartitions(bool[] bipartition) {
        var evenCount = 0;
        var oddCount = 0;
        
        foreach (var isEven in bipartition) {
            if (isEven) evenCount++;
            else oddCount++;
        }
        
        return (evenCount, oddCount);
    }
}