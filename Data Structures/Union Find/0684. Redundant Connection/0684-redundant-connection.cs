namespace LeetCodeSolutions.DataStructures/UnionFind;

/*
 * 0684. Redundant Connection
 * Difficulty: Medium
 * Submission Time: 2025-01-29 07:45:07
 * Created by vahtyah on 2025-01-29 08:03:14
 */
 
public class Solution {
    public int[] FindRedundantConnection(int[][] edges) {
        int n = edges.Length;
        var parent = new int[n + 1];
        var rank = new int[n + 1];

        for (int i = 0; i <= n; i++) {
            parent[i] = i;
            rank[i] = 1;
        }

        foreach (var edge in edges) {
            if (!Union(parent, rank, edge[0], edge[1]))
                return edge;
        }

        return Array.Empty<int>(); 
    }

    private int Find(int[] parent, int x) {
        if (parent[x] != x) {
            parent[x] = Find(parent, parent[x]);
        }
        return parent[x];
    }

    private bool Union(int[] parent, int[] rank, int x, int y) {
        int rootX = Find(parent, x);
        int rootY = Find(parent, y);

        if (rootX == rootY)
            return false;  

        if (rank[rootX] > rank[rootY]) {
            parent[rootY] = rootX;
        } else if (rank[rootX] < rank[rootY]) {
            parent[rootX] = rootY;
        } else {
            parent[rootY] = rootX;
            rank[rootX]++;
        }

        return true;
    }
}