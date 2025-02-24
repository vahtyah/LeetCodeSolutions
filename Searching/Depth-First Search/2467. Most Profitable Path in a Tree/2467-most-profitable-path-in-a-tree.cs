namespace LeetCodeSolutions.Searching/Depth-FirstSearch;

/*
 * 2467. Most Profitable Path in a Tree
 * Difficulty: Medium
 * Submission Time: 2025-02-24 06:11:11
 * Created by vahtyah on 2025-02-24 06:12:14
*/
 
public class Solution {
    private int[] adjData;
    private int[] adjIndex;
    private int[] bobTimes;
    private int[] visited;
    private int maxProfit;
    private int[] amount;
    private int n;
    
    public int MostProfitablePath(int[][] edges, int bob, int[] amount) {
        this.amount = amount;
        n = amount.Length;
        
        // Count edges
        int[] edgeCount = new int[n];
        for (int i = 0; i < n - 1; i++) {
            edgeCount[edges[i][0]]++;
            edgeCount[edges[i][1]]++;
        }
        
        // Build optimized adjacency structure
        int totalEdges = (n - 1) << 1;
        adjData = new int[totalEdges];
        adjIndex = new int[n + 1];
        
        // Calculate starting indices
        for (int i = 1; i < n; i++) {
            adjIndex[i] = adjIndex[i - 1] + edgeCount[i - 1];
        }
        
        // Fill adjacency data
        int[] currentIndex = new int[n];
        Array.Copy(adjIndex, currentIndex, n);
        
        for (int i = 0; i < n - 1; i++) {
            int u = edges[i][0], v = edges[i][1];
            adjData[currentIndex[u]++] = v;
            adjData[currentIndex[v]++] = u;
        }
        
        // Initialize arrays
        bobTimes = new int[n];
        visited = new int[n];
        for (int i = 0; i < n; i++) {
            bobTimes[i] = n + 1;
        }
        
        maxProfit = int.MinValue;
        
        // Find Bob's path
        FindBobPath(bob, -1, 0);
        
        // Find Alice's maximum profit path
        AliceDFS(0, -1, 0, 0);
        
        return maxProfit;
    }
    
    private bool FindBobPath(int node, int parent, int time) {
        if (node == 0) {
            bobTimes[node] = time;
            return true;
        }
        
        visited[node] = 1;
        int start = adjIndex[node];
        int end = node == n - 1 ? adjData.Length : adjIndex[node + 1];
        
        for (int i = start; i < end; i++) {
            int next = adjData[i];
            if (next != parent && visited[next] == 0 && FindBobPath(next, node, time + 1)) {
                bobTimes[node] = time;
                return true;
            }
        }
        
        visited[node] = 0;
        return false;
    }
    
    private void AliceDFS(int node, int parent, int time, int total) {
        // Calculate current node value
        int curr = amount[node];
        int bobTime = bobTimes[node];
        curr = time > bobTime ? 0 : time == bobTime ? curr >> 1 : curr;
        
        total += curr;
        
        int start = adjIndex[node];
        int end = node == n - 1 ? adjData.Length : adjIndex[node + 1];
        bool isLeaf = (start + 1 >= end && node != 0) || (node == 0 && start >= end);
        
        if (isLeaf) {
            maxProfit = Math.Max(maxProfit, total);
            return;
        }
        
        // Process children
        for (int i = start; i < end; i++) {
            int next = adjData[i];
            if (next != parent) {
                AliceDFS(next, node, time + 1, total);
            }
        }
    }
}