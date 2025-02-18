# Union Find

A **union-find** data structure (also known as a disjoint-set data structure) is a data structure that keeps track of a set of elements partitioned into a number of disjoint (non-overlapping) subsets. It provides two main operations:
- **Union:** Merge two sets into one set.
- **Find:** Determine which set a particular element belongs to.

## Key Concepts

1. **Applications:**
    - Union-find is used in various algorithms and problems, such as Kruskal's minimum spanning tree algorithm, percolation problems, and network connectivity problems.
    - It is used to maintain the connected components of a graph.
2. **Time Complexity:**
    - The time complexity of union-find operations is typically `O(log n)` or `O(α(n))`, where `α(n)` is the inverse Ackermann function, which grows very slowly and is considered a constant for all practical purposes.
    

## C# Example
```csharp
public class UnionFind
{
    private int[] parent;
    private int[] rank;
    private int count;

    public UnionFind(int n)
    {
        if (n < 0) throw new ArgumentException("n must be non-negative");
        
        count = n;
        parent = new int[n];
        rank = new int[n];
        
        // Initialize each element as its own set
        for (int i = 0; i < n; i++)
        {
            parent[i] = i;
            rank[i] = 0;
        }
    }

    // Find with path compression
    public int Find(int p)
    {
        ValidateElement(p);
        
        while (p != parent[p])
        {
            parent[p] = parent[parent[p]];  // Path compression
            p = parent[p];
        }
        return p;
    }

    // Union with rank
    public void Union(int p, int q)
    {
        int rootP = Find(p);
        int rootQ = Find(q);
        
        if (rootP == rootQ) return;

        // Make root of smaller rank point to root of larger rank
        if (rank[rootP] < rank[rootQ])
        {
            parent[rootP] = rootQ;
        }
        else if (rank[rootP] > rank[rootQ])
        {
            parent[rootQ] = rootP;
        }
        else
        {
            parent[rootQ] = rootP;
            rank[rootP]++;
        }
        count--;
    }

    // Check if two elements are in the same set
    public bool Connected(int p, int q)
    {
        return Find(p) == Find(q);
    }

    // Get number of disjoint sets
    public int Count()
    {
        return count;
    }

    private void ValidateElement(int p)
    {
        int n = parent.Length;
        if (p < 0 || p >= n)
        {
            throw new ArgumentException("index " + p + " is not between 0 and " + (n-1));
        }
    }
}

public class Program
{
    public static void Main()
    {
        int n = 5;
        UnionFind uf = new UnionFind(n);
        
        uf.Union(0, 1);
        uf.Union(1, 2);
        uf.Union(3, 4);
        
        Console.WriteLine(uf.Connected(0, 2));  // True
        Console.WriteLine(uf.Connected(0, 3));  // False
        Console.WriteLine(uf.Count());          // 2
    }
}
```


## Solutions

### ![Medium](https://img.shields.io/badge/Medium-fac31d)

[0128. Longest Consecutive Sequence](/Data%20Structures%2FUnion%20Find%2F0128.%20Longest%20Consecutive%20Sequence): Find the longest consecutive sequence within an unsorted array

[0684. Redundant Connection](/Data%20Structures%2FUnion%20Find%2F0684.%20Redundant%20Connection): Find the redundant connection in a graph using union-find.

### ![Hard](https://img.shields.io/badge/Hard-f8615c)

[0827. Making A Large Island](/Data%20Structures%2FUnion%20Find%2F0827.%20Making%20A%20Large%20Island): Find the size of the largest island that can be created by changing at most

[2493. Divide Nodes Into the Maximum Number of Groups](/Data%20Structures%2FUnion%20Find%2F2493.%20Divide%20Nodes%20Into%20the%20Maximum%20Number%20of%20Groups): Divide nodes into the maximum number of groups such that each group has exactly one node from each connected component.
