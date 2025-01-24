namespace LeetCodeSolutions.Searching/Depth-FirstSearch;

/*
 * 0802. Find Eventual Safe States
 * Difficulty: Medium
 * Created by vahtyah on 2025-01-24 09:04:45
 */
 
public class Solution {
    public IList<int> EventualSafeNodes(int[][] graph) {
        int n = graph.Length;
        byte[] state = new byte[n]; // 0: unvisited, 1: in current path (unsafe), 2: safe
        var result = new List<int>(n); 
        
        for (int i = 0; i < n; i++) {
            if (DFS(i)) {
                result.Add(i);
            }
        }
        
        return result;

        bool DFS(int node) {
            if (state[node] == 1) return false;
            if (state[node] == 2) return true;
            
            state[node] = 1; 
            
            foreach (int next in graph[node]) {
                if (!DFS(next)) return false;
            }
            
            state[node] = 2; 
            return true;
        }
    }
}