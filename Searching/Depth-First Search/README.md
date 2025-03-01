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

[0222. Count Complete Tree Nodes](/Searching%2FDepth-First%20Search%2F0222.%20Count%20Complete%20Tree%20Nodes): Count nodes in a complete binary tree

[0226. Invert Binary Tree](/Searching%2FDepth-First%20Search%2F0226.%20Invert%20Binary%20Tree): Reverse left and right subtrees of each node in a binary tree

[0530. Minimum Absolute Difference in BST](/Searching%2FDepth-First%20Search%2F0530.%20Minimum%20Absolute%20Difference%20in%20BST): Find minimum absolute difference between any two BST nodes

[0637. Average of Levels in Binary Tree](/Searching%2FDepth-First%20Search%2F0637.%20Average%20of%20Levels%20in%20Binary%20Tree): Calculate the average value of nodes at each level

### ![Medium](https://img.shields.io/badge/Medium-fac31d)

[0102. Binary Tree Level Order Traversal](/Searching%2FDepth-First%20Search%2F0102.%20Binary%20Tree%20Level%20Order%20Traversal): Traverse binary tree level by level

[0103. Binary Tree Zigzag Level Order Traversal](/Searching%2FDepth-First%20Search%2F0103.%20Binary%20Tree%20Zigzag%20Level%20Order%20Traversal): Traverse a binary tree level by level, zigzagging direction

[0114. Flatten Binary Tree to Linked List](/Searching%2FDepth-First%20Search%2F0114.%20Flatten%20Binary%20Tree%20to%20Linked%20List): Rearrange binary tree nodes into a right-leaning linked list

[0129. Sum Root to Leaf Numbers](/Searching%2FDepth-First%20Search%2F0129.%20Sum%20Root%20to%20Leaf%20Numbers): Sum all root-to-leaf path numbers in a binary tree

[0199. Binary Tree Right Side View](/Searching%2FDepth-First%20Search%2F0199.%20Binary%20Tree%20Right%20Side%20View): Return nodes visible from the right side of a tree

[0230. Kth Smallest Element in a BST](/Searching%2FDepth-First%20Search%2F0230.%20Kth%20Smallest%20Element%20in%20a%20BST): Find the kth smallest element in a binary search tree

[0236. Lowest Common Ancestor of a Binary Tree](/Searching%2FDepth-First%20Search%2F0236.%20Lowest%20Common%20Ancestor%20of%20a%20Binary%20Tree): Find the deepest common ancestor of two nodes

[0802. Find Eventual Safe States](/Searching%2FDepth-First%20Search%2F0802.%20Find%20Eventual%20Safe%20States): Find the eventual safe states of a directed graph

[2467. Most Profitable Path in a Tree](/Searching%2FDepth-First%20Search%2F2467.%20Most%20Profitable%20Path%20in%20a%20Tree): Find maximum profit path in a tree with edge profits

[2658. Maximum Number of Fish in a Grid](/Searching%2FDepth-First%20Search%2F2658.%20Maximum%20Number%20of%20Fish%20in%20a%20Grid): Find the maximum number of fish that can be caught in a grid

### ![Hard](https://img.shields.io/badge/Hard-f8615c)

[0124. Binary Tree Maximum Path Sum](/Searching%2FDepth-First%20Search%2F0124.%20Binary%20Tree%20Maximum%20Path%20Sum): Find the maximum sum path in a binary tree

[1028. Recover a Tree From Preorder Traversal](/Searching%2FDepth-First%20Search%2F1028.%20Recover%20a%20Tree%20From%20Preorder%20Traversal): Recover a binary tree from a preorder traversal sequence
