# Union Find

A **union-find** data structure (also known as a disjoint-set data structure) is a data structure that keeps track of a set of elements partitioned into a number of disjoint (non-overlapping) subsets. It provides two main operations:

## Key Concepts

1. **Union:** Merge two sets into one set.
2. **Find:** Determine which set a particular element belongs to.
3. **Applications:**
    - Union-find is used in various algorithms and problems, such as Kruskal's minimum spanning tree algorithm, percolation problems, and network connectivity problems.
    - It is used to maintain the connected components of a graph.
4. **Time Complexity:**
    - The time complexity of union-find operations is typically `O(log n)` or `O(α(n))`, where `α(n)` is the inverse Ackermann function, which grows very slowly and is considered a constant for all practical purposes.
    

## C# Example
```csharp
public class UnionFind
{
    private int[] parent;
    private int[] rank;

    public UnionFind(int n)
    {
        parent = new int[n];
        rank = new int[n];
        for (int i = 0; i < n; i++)
        {
            parent[i] = i;
            rank[i] = 0;
        }
    }

    public int Find(int x)
    {
        if (parent[x] != x)
        {
            parent[x] = Find(parent[x]);
        }
        return parent[x];
    }

    public void Union(int x, int y)
    {
        int rootX = Find(x);
        int rootY = Find(y);

        if (rootX == rootY)
        {
            return;
        }

        if (rank[rootX] < rank[rootY])
        {
            parent[rootX] = rootY;
        }
        else if (rank[rootX] > rank[rootY])
        {
            parent[rootY] = rootX;
        }
        else
        {
            parent[rootY] = rootX;
            rank[rootX]++;
        }
    }
}
```


## Solutions

### ![Medium](https://img.shields.io/badge/Medium-fac31d)

[0684. Redundant Connection](/Data%20Structures%2FUnion%20Find%2F0684.%20Redundant%20Connection): Find the redundant connection in a graph using union-find.
