namespace LeetCodeSolutions.Searching/Breadth-FirstSearch;

/*
 * 2493. Divide Nodes Into the Maximum Number of Groups
 * Difficulty: Hard
 * Submission Time: 2025-01-30 07:21:25
 * Created by vahtyah on 2025-01-30 07:23:19
 */
 
public class Solution {
    // Pre-allocate static buffers to avoid repeated allocations across test cases
    private static int[] levels = new int[100001];
    private static int[] queue = new int[100001];
    private static int[] parent = new int[100001];
    private static int[] rank = new int[100001];
    private static int[] componentMaxGroups = new int[100001];
    private static bool[] seen = new bool[100001];
    
    public int MagnificentSets(int n, int[][] edges) {
        // Reset arrays for reuse
        Array.Fill(componentMaxGroups, 0, 0, n + 1);
        Array.Fill(seen, false, 0, n + 1);
        Array.Clear(rank, 0, n + 1);
        
        // Initialize UnionFind
        for (int i = 0; i <= n; i++) {
            parent[i] = i;
        }
        
        // Create compact adjacency list
        var graph = new int[n + 1][];
        var tempLists = new List<int>[n + 1];
        for (int i = 1; i <= n; i++) {
            tempLists[i] = new List<int>();
        }
        
        // Build graph and union components
        foreach (var edge in edges) {
            int u = edge[0], v = edge[1];
            tempLists[u].Add(v);
            tempLists[v].Add(u);
            Union(u, v);
        }
        
        // Convert to array-based representation for better cache locality
        for (int i = 1; i <= n; i++) {
            graph[i] = tempLists[i].ToArray();
        }
        
        for (int start = 1; start <= n; start++) {
            int root = Find(start);
            int groups = BFS(start, n, graph);
            
            if (groups == -1) return -1;
            componentMaxGroups[root] = Math.Max(componentMaxGroups[root], groups);
        }
        
        int result = 0;
        // Sum up max groups for each component
        for (int i = 1; i <= n; i++) {
            int root = Find(i);
            if (!seen[root]) {
                seen[root] = true;
                result += componentMaxGroups[root];
            }
        }
        
        return result;
    }
    
    private int BFS(int start, int n, int[][] graph) {
        int front = 0, rear = 0;
        Array.Fill(levels, -1, 0, n + 1);
        
        queue[rear++] = start;
        levels[start] = 0;
        int maxLevel = 0;
        
        while (front < rear) {
            int curr = queue[front++];
            int currLevel = levels[curr];
            var neighbors = graph[curr];
            int len = neighbors.Length;
            
            // Manual loop unrolling for better performance
            for (int i = 0; i < len; i++) {
                int next = neighbors[i];
                if (levels[next] == -1) {
                    levels[next] = currLevel + 1;
                    maxLevel = Math.Max(maxLevel, levels[next]);
                    queue[rear++] = next;
                } else if ((levels[next] ^ currLevel) % 2 == 0) {
                    return -1;
                }
            }
        }
        
        return maxLevel + 1;
    }
    
    private int Find(int x) {
        while (x != parent[x]) {
            parent[x] = parent[parent[x]];
            x = parent[x];
        }
        return x;
    }
    
    private void Union(int x, int y) {
        int rootX = Find(x), rootY = Find(y);
        
        if (rootX == rootY) return;
        
        if (rank[rootX] < rank[rootY]) {
            parent[rootX] = rootY;
        } else {
            parent[rootY] = rootX;
            if (rank[rootX] == rank[rootY]) rank[rootX]++;
        }
    }
}

public class Solution {
    public int MagnificentSets(int n, int[][] edges) {
        // Create adjacency list with pre-allocated capacity
        var graph = new List<int>[n + 1];
        for (int i = 1; i <= n; i++) {
            graph[i] = new List<int>(n);
        }
        
        // Build graph
        foreach (var edge in edges) {
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }
        
        var uf = new UnionFind(n + 1);
        foreach (var edge in edges) {
            uf.Union(edge[0], edge[1]);
        }
        
        // Array to store max groups for each component
        var componentMaxGroups = new int[n + 1];
        
        // Pre-allocated arrays for BFS to avoid repeated allocation
        var queue = new int[n + 1];
        var levels = new int[n + 1];
        
        for (int start = 1; start <= n; start++) {
            int root = uf.Find(start);
            int groups = BFS(start, graph, levels, queue);
            
            if (groups == -1) return -1;
            componentMaxGroups[root] = Math.Max(componentMaxGroups[root], groups);
        }
        
        int result = 0;
        var seen = new bool[n + 1];
        
        // Sum up max groups for each component
        for (int i = 1; i <= n; i++) {
            int root = uf.Find(i);
            if (!seen[root]) {
                seen[root] = true;
                result += componentMaxGroups[root];
            }
        }
        
        return result;
    }
    
    private int BFS(int start, List<int>[] graph, int[] levels, int[] queue) {
        Array.Fill(levels, -1);
        int front = 0, rear = 0;
        
        queue[rear++] = start;
        levels[start] = 0;
        int maxLevel = 0;
        
        while (front < rear) {
            int curr = queue[front++];
            
            foreach (int next in graph[curr]) {
                if (levels[next] == -1) {
                    levels[next] = levels[curr] + 1;
                    maxLevel = Math.Max(maxLevel, levels[next]);
                    queue[rear++] = next;
                } else if (levels[next] % 2 == levels[curr] % 2) {
                    return -1;
                }
            }
        }
        
        return maxLevel + 1;
    }
    
    private class UnionFind {
        private readonly int[] parent;
        private readonly int[] rank;
        
        public UnionFind(int size) {
            parent = new int[size];
            rank = new int[size];
            for (int i = 0; i < size; i++) {
                parent[i] = i;
            }
        }
        
        public int Find(int x) {
            while (x != parent[x]) {
                parent[x] = parent[parent[x]];  // Path compression
                x = parent[x];
            }
            return x;
        }
        
        public void Union(int x, int y) {
            int rootX = Find(x);
            int rootY = Find(y);
            
            if (rootX == rootY) return;
            
            if (rank[rootX] < rank[rootY]) {
                parent[rootX] = rootY;
            } else {
                parent[rootY] = rootX;
                if (rank[rootX] == rank[rootY]) {
                    rank[rootX]++;
                }
            }
        }
    }
}