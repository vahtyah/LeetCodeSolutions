# Depth-First Search

The **Depth-First Search (DFS)** algorithm is a graph traversal technique that explores as far as possible along each branch before backtracking. It is often used to solve problems involving graph traversal, such as finding connected components, cycles, or paths in a graph.

## Key Concepts

1. **Input:** A graph represented as an adjacency list or matrix, a starting node, and a goal node (if applicable).
2. **Output:** The nodes visited in the order they were explored.
3. **Logic:**
   - Start at the initial node and mark it as visited.
   - For each unvisited neighbor of the current node:
     - Recursively call the DFS function on the neighbor.
   - Repeat this process until all nodes have been visited.
   - If a goal node is specified, stop the search when the goal node is reached.
   - Return the list of visited nodes.
4. **Time complexity:** O(V + E), where V is the number of vertices and E is the number of edges in the graph.

## C# Implementation

```csharp
public class Graph
{
    private Dictionary<int, List<int>> adjList;

    public Graph()
    {
        adjList = new Dictionary<int, List<int>>();
    }

    public void AddEdge(int u, int v)
    {
        if (!adjList.ContainsKey(u))
        {
            adjList[u] = new List<int>();
        }
        adjList[u].Add(v);
    }

    public List<int> DFS(int start)
    {
        List<int> visited = new List<int>();
        HashSet<int> visitedSet = new HashSet<int>();
        DFSUtil(start, visited, visitedSet);
        return visited;
    }

    private void DFSUtil(int node, List<int> visited, HashSet<int> visitedSet)
    {
        visited.Add(node);
        visitedSet.Add(node);

        if (adjList.ContainsKey(node))
        {
            foreach (int neighbor in adjList[node])
            {
                if (!visitedSet.Contains(neighbor))
                {
                    DFSUtil(neighbor, visited, visitedSet);
                }
            }
        }
    }
}
```

## Solutions

### ![Easy](https://img.shields.io/badge/Easy-46c6c2)

[0100. Same Tree](/Searching%2FDepth-First%20Search%2F0100.%20Same%20Tree): Determine if two binary trees are structurally identical

[0101. Symmetric Tree](/Searching%2FDepth-First%20Search%2F0101.%20Symmetric%20Tree): Check if a binary tree is mirror-symmetrical

[0104. Maximum Depth of Binary Tree](/Searching%2FDepth-First%20Search%2F0104.%20Maximum%20Depth%20of%20Binary%20Tree): Find the maximum depth of a binary tree

[0112. Path Sum](/Searching%2FDepth-First%20Search%2F0112.%20Path%20Sum): Determine if root-to-leaf path sums to target

[0226. Invert Binary Tree](/Searching%2FDepth-First%20Search%2F0226.%20Invert%20Binary%20Tree): Reverse left and right subtrees of each node in a binary tree

### ![Medium](https://img.shields.io/badge/Medium-fac31d)

[0802. Find Eventual Safe States](/Searching%2FDepth-First%20Search%2F0802.%20Find%20Eventual%20Safe%20States): Find the eventual safe states of a directed graph

[2467. Most Profitable Path in a Tree](/Searching%2FDepth-First%20Search%2F2467.%20Most%20Profitable%20Path%20in%20a%20Tree): Find maximum profit path in a tree with edge profits

[2658. Maximum Number of Fish in a Grid](/Searching%2FDepth-First%20Search%2F2658.%20Maximum%20Number%20of%20Fish%20in%20a%20Grid): Find the maximum number of fish that can be caught in a grid

### ![Hard](https://img.shields.io/badge/Hard-f8615c)

[1028. Recover a Tree From Preorder Traversal](/Searching%2FDepth-First%20Search%2F1028.%20Recover%20a%20Tree%20From%20Preorder%20Traversal): Recover a binary tree from a preorder traversal sequence
