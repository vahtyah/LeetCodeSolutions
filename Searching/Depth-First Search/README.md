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

[//]: # (## Solutions

### ![Medium](https://img.shields.io/badge/Medium-fac31d)

[0802. Find Eventual Safe States](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Searching%2FDepth-First%20Search%2F0802.%20Find%20Eventual%20Safe%20States): Find the eventual safe states in a directed graph.
