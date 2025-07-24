namespace LeetCodeSolutions.Searching/Depth-FirstSearch;

/*
 * 2322. Minimum Score After Removals on a Tree
 * Difficulty: Hard
 * Submission Time: 2025-07-24 01:58:27
 * Created by vahtyah on 2025-07-24 01:58:57
*/
 
public class Solution {
    public int MinimumScore(int[] nums, int[][] edges) {
        int n = nums.Length;
        
        // Build adjacency list representation of the tree
        List<List<int>> adjacencyList = BuildAdjacencyList(n, edges);
        
        // Arrays to store subtree XOR values and Euler tour timestamps
        int[] subtreeXor = new int[n];
        int[] visitTime = new int[n];    // Entry timestamp during DFS
        int[] exitTime = new int[n];     // Exit timestamp during DFS
        
        // Perform DFS to calculate subtree XORs and timestamps
        int timestamp = 0;
        CalculateSubtreeValues(0, -1, nums, adjacencyList, subtreeXor, visitTime, exitTime, ref timestamp);
        
        // Find minimum possible score by considering all node pairs
        return FindMinimumScore(n, subtreeXor, visitTime, exitTime);
    }
    
    // Builds the adjacency list representation of the tree
    private List<List<int>> BuildAdjacencyList(int n, int[][] edges) {
        var adjacencyList = new List<List<int>>();
        for (int i = 0; i < n; i++) {
            adjacencyList.Add(new List<int>());
        }
        
        foreach (var edge in edges) {
            adjacencyList[edge[0]].Add(edge[1]);
            adjacencyList[edge[1]].Add(edge[0]);
        }
        
        return adjacencyList;
    }
    
    // DFS to calculate subtree XOR values and record Euler tour timestamps
    private void CalculateSubtreeValues(
        int node, 
        int parent, 
        int[] values, 
        List<List<int>> adjacencyList, 
        int[] subtreeXor, 
        int[] visitTime, 
        int[] exitTime, 
        ref int timestamp
    ) {
        // Record entry timestamp
        visitTime[node] = timestamp++;
        
        // Initialize with current node's value
        subtreeXor[node] = values[node];
        
        // Visit all children
        foreach (int child in adjacencyList[node]) {
            if (child == parent) continue;
            
            CalculateSubtreeValues(
                child, node, values, adjacencyList, subtreeXor, visitTime, exitTime, ref timestamp);
            
            // Update subtree XOR with child's subtree XOR
            subtreeXor[node] ^= subtreeXor[child];
        }
        
        // Record exit timestamp
        exitTime[node] = timestamp;
    }
    
    // Tries all possible node pairs to find minimum score
    private int FindMinimumScore(int n, int[] subtreeXor, int[] visitTime, int[] exitTime) {
        int minScore = int.MaxValue;
        int totalXor = subtreeXor[0]; // Root's XOR is the total XOR
        
        // Try all pairs of nodes (excluding the root)
        for (int u = 1; u < n; u++) {
            for (int v = u + 1; v < n; v++) {
                int component1, component2, component3;
                
                // Check if v is in u's subtree
                if (IsDescendant(u, v, visitTime, exitTime)) {
                    component1 = totalXor ^ subtreeXor[u];         // Everything except u's subtree
                    component2 = subtreeXor[u] ^ subtreeXor[v];    // u's subtree except v's subtree
                    component3 = subtreeXor[v];                    // v's subtree
                } 
                // Check if u is in v's subtree
                else if (IsDescendant(v, u, visitTime, exitTime)) {
                    component1 = totalXor ^ subtreeXor[v];         // Everything except v's subtree
                    component2 = subtreeXor[v] ^ subtreeXor[u];    // v's subtree except u's subtree
                    component3 = subtreeXor[u];                    // u's subtree
                } 
                // Neither is in the other's subtree (disjoint subtrees)
                else {
                    component1 = totalXor ^ subtreeXor[u] ^ subtreeXor[v]; // Remainder after removing both subtrees
                    component2 = subtreeXor[u];                            // u's subtree
                    component3 = subtreeXor[v];                            // v's subtree
                }
                
                int score = CalculateScore(component1, component2, component3);
                minScore = Math.Min(minScore, score);
            }
        }
        
        return minScore;
    }
    
    // Check if child is a descendant of parent using Euler tour timestamps
    private bool IsDescendant(int parent, int child, int[] visitTime, int[] exitTime) {
        return visitTime[parent] < visitTime[child] && exitTime[child] <= exitTime[parent];
    }
    
    // Calculate score as max - min of the three component values
    private int CalculateScore(int part1, int part2, int part3) {
        return Math.Max(part1, Math.Max(part2, part3)) - 
               Math.Min(part1, Math.Min(part2, part3));
    }
}