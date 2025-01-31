namespace LeetCodeSolutions.DataStructures/UnionFind;

/*
 * 0827. Making A Large Island
 * Difficulty: Hard
 * Submission Time: 2025-01-31 10:43:50
 * Created by vahtyah on 2025-01-31 10:46:04
 */
 
public class Solution {
    public int LargestIsland(int[][] grid) {
        int n = grid.Length;
        var parents = new int[n * n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                var curr = i * n + j;
                if (grid[i][j] == 1)
                {
                    parents[curr] = curr;

                    if (i > 0 && grid[i - 1][j] == 1)
                    {
                        Union(parents, curr - n, curr);
                    }
                    if (j > 0 && grid[i][j - 1] == 1)
                    {
                        Union(parents, curr - 1, curr);
                    }
                }
            }
        }

        var islands = new int[n * n];
        int result = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (grid[i][j] == 1)
                {
                    int curr = i * n + j;
                    int p = curr;
                    while (parents[p] != p)
                    {
                        p = parents[p];
                    }

                    while (parents[curr] != curr)
                    {
                        int temp = parents[curr];
                        parents[curr] = p;
                        curr = temp;
                    }
                    parents[curr] = p;

                    result = Math.Max(result, ++islands[p]);
                }
            }
        }

        var visited = new bool[n * n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (grid[i][j] == 0)
                {
                    int value = 1, curr = i * n + j;
                    if (i > 0 && grid[i - 1][j] == 1)
                    {
                        value += islands[parents[curr - n]];
                        visited[parents[curr - n]] = true;
                    }
                    if (i < n - 1 && grid[i + 1][j] == 1 && !visited[parents[curr + n]])
                    {
                        value += islands[parents[curr + n]];
                        visited[parents[curr + n]] = true;
                    }
                    if (j > 0 && grid[i][j - 1] == 1 && !visited[parents[curr - 1]])
                    {
                        value += islands[parents[curr - 1]];
                        visited[parents[curr - 1]] = true;
                    }
                    if (j < n - 1 && grid[i][j + 1] == 1 && !visited[parents[curr + 1]])
                    {
                        value +=  islands[parents[curr + 1]];
                        visited[parents[curr + 1]] = true;
                    }
                    result = Math.Max(result, value);

                    if (i > 0)
                    {
                        visited[parents[curr - n]] = false;
                    }
                    if (i < n - 1)
                    {
                        visited[parents[curr + n]] = false;
                    }
                    if (j > 0)
                    {
                        visited[parents[curr - 1]] = false;
                    }
                    if (j < n - 1)
                    {
                        visited[parents[curr + 1]] = false;
                    }
                }
            }
        }
        return result;
    }

    private void Union(int[] parents, int x, int y)
    {
        int p = x;
        while (parents[p] != p)
        {
            p = parents[p];
        }

        while (parents[x] != x)
        {
            int temp = parents[x];
            parents[x] = p;
            x = temp;
        }
        parents[x] = p;

        while (parents[y] != y)
        {
            int temp = parents[y];
            parents[y] = p;
            y = temp;
        }
        parents[y] = p;
    }
}

public class Solution {
    private int[] parent;
    private int[] size;
    private int maxSize;
    
    public int LargestIsland(int[][] grid) {
        int n = grid.Length;
        parent = new int[n * n];
        size = new int[n * n];
        maxSize = 1;
        
        for (int i = 0; i < n * n; i++) {
            parent[i] = i;
            size[i] = 1;
        }
        
        int[][] directions = new int[][] {
            new int[] {1, 0},
            new int[] {-1, 0},
            new int[] {0, 1},
            new int[] {0, -1}
        };
        
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                if (grid[i][j] == 1) {
                    int index = i * n + j;
                    foreach (var dir in directions) {
                        int ni = i + dir[0];
                        int nj = j + dir[1];
                        
                        if (ni >= 0 && ni < n && nj >= 0 && nj < n && grid[ni][nj] == 1) {
                            Union(index, ni * n + nj);
                        }
                    }
                    maxSize = Math.Max(maxSize, size[Find(index)]);
                }
            }
        }
        
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                if (grid[i][j] == 0) {
                    HashSet<int> connectedGroups = new HashSet<int>();
                    int potentialSize = 1;  
                    
                    foreach (var dir in directions) {
                        int ni = i + dir[0];
                        int nj = j + dir[1];
                        
                        if (ni >= 0 && ni < n && nj >= 0 && nj < n && grid[ni][nj] == 1) {
                            int root = Find(ni * n + nj);
                            if (!connectedGroups.Contains(root)) {
                                potentialSize += size[root];
                                connectedGroups.Add(root);
                            }
                        }
                    }
                    maxSize = Math.Max(maxSize, potentialSize);
                }
            }
        }
        
        return maxSize;
    }
    
    private int Find(int x) {
        if (parent[x] != x) {
            parent[x] = Find(parent[x]);
        }
        return parent[x];
    }
    
    private void Union(int x, int y) {
        int rootX = Find(x);
        int rootY = Find(y);
        
        if (rootX != rootY) {
            parent[rootY] = rootX;
            size[rootX] += size[rootY];
        }
    }
}