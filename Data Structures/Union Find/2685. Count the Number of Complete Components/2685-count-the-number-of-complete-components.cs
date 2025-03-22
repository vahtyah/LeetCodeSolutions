namespace LeetCodeSolutions.DataStructures/UnionFind;

/*
 * 2685. Count the Number of Complete Components
 * Difficulty: Medium
 * Submission Time: 2025-03-22 04:59:32
 * Created by vahtyah on 2025-03-22 04:59:55
*/
 
public class Solution {
    public int CountCompleteComponents(int n, int[][] edges) {
        DisjointSet ds = new DisjointSet(n);
        int ans = 0;

        foreach (var edge in edges) {
            ds.Union(edge[0], edge[1]);
        }

        for (int i = 0; i < n; i++) {
            if (ds.IsCompleteComponent(i)) {
                ans++;
            }
        }
        
        return ans;
    }
}

public class DisjointSet {
    private int[] parent;
    private int[] size;
    private int[] edges;

    public DisjointSet(int n) {
        parent = new int[n];
        size = new int[n];
        edges = new int[n];
        
        for (int i = 0; i < n; i++) {
            parent[i] = i;      
            size[i] = 1;        
        }
    }

    public int Find(int x) {
        if (parent[x] != x) {
            parent[x] = Find(parent[x]); 
        }
        return parent[x];
    }

    public void Union(int x, int y) {
        int rootX = Find(x);
        int rootY = Find(y);

        if (rootX == rootY) {
            edges[rootX]++;
            return;
        }

        if (size[rootX] < size[rootY]) {
            int temp = rootX;
            rootX = rootY;
            rootY = temp;
        }

        parent[rootY] = rootX;
        size[rootX] += size[rootY];
        edges[rootX] += edges[rootY] + 1;
    }

    public bool IsCompleteComponent(int x) {
        int root = Find(x);
        
        if (root == x) {
            return edges[root] == (size[root] * (size[root] - 1)) / 2;
        }
        
        return false;
    }
}