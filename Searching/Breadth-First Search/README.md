# Breath-First Search

The **Breath-First Search (BFS)** algorithm is a graph traversal technique that explores all the vertices in a graph level by level. It starts at a given source vertex and explores all the vertices at the present depth before moving on to the vertices at the next depth level.

## Key Concepts

1. **Input:** A graph with nodes and edges, a start node, and a goal node.
2. **Output:** The shortest path from the start node to the goal node.
3. **Logic:**
   - Initialize a queue to store nodes to be explored.
   - Add the start node to the queue.
   - While the queue is not empty:
     - Dequeue the front node from the queue.
     - If the dequeued node is the goal node, reconstruct the path and return it.
     - Generate the neighbors of the dequeued node.
     - For each neighbor:
       - If the neighbor has not been visited:
         - Mark the neighbor as visited.
         - Add the neighbor to the queue.
   - If the queue is empty and the goal node has not been reached, there is no path.
   - Return the shortest path from the start node to the goal node.
4. Time complexity: O(V + E), where V is the number of vertices and E is the number of edges in the graph.

## C# Implementation

```csharp
public class BFSNode
{
    public int X { get; set; }
    public int Y { get; set; }
    public BFSNode Parent { get; set; }

    public BFSNode(int x, int y, BFSNode parent)
    {
        X = x;
        Y = y;
        Parent = parent;
    }
}

public class BreadthFirstSearch
{
    public static List<(int, int)> FindShortestPath(int[,] grid, (int, int) start, (int, int) goal)
    {
        int rows = grid.GetLength(0);
        int cols = grid.GetLength(1);
        int[,] directions = { { 0, 1 }, { 0, -1 }, { 1, 0 }, { -1, 0 } };
        Queue<BFSNode> queue = new Queue<BFSNode>();
        HashSet<(int, int)> visited = new HashSet<(int, int)>();
        BFSNode startNode = new BFSNode(start.Item1, start.Item2, null);
        queue.Enqueue(startNode);
        visited.Add(start);

        while (queue.Count > 0)
        {
            BFSNode current = queue.Dequeue();
            if (current.X == goal.Item1 && current.Y == goal.Item2)
            {
                List<(int, int)> path = new List<(int, int)>();
                while (current != null)
                {
                    path.Add((current.X, current.Y));
                    current = current.Parent;
                }
                path.Reverse();
                return path;
            }

            foreach (int[] dir in directions)
            {
                int nextX = current.X + dir[0];
                int nextY = current.Y + dir[1];
                if (nextX >= 0 && nextX < rows && nextY >= 0 && nextY < cols && grid[nextX, nextY] == 0 && !visited.Contains((nextX, nextY)))
                {
                    BFSNode nextNode = new BFSNode(nextX, nextY, current);
                    queue.Enqueue(nextNode);
                    visited.Add((nextX, nextY));
                }
            }
        }

        return new List<(int, int)>();
    }
}

public class Program
{
    public static void Main()
    {
        int[,] grid = {
            { 0, 1, 0, 0, 0 },
            { 0, 0, 0, 1, 0 },
            { 0, 1, 0, 1, 0 },
            { 0, 1, 0, 0, 0 },
            { 0, 0, 0, 0, 0 }
        };
        var start = (0, 0);
        var goal = (4, 4);
        List<(int, int)> path = BreadthFirstSearch.FindShortestPath(grid, start, goal);
        foreach (var node in path)
        {
            Console.WriteLine($"({node.Item1}, {node.Item2})");
        }
    }
}
```

## Solutions

[//]: # (### ![Easy]&#40;https://img.shields.io/badge/Easy-46c6c2&#41;)

### ![Medium](https://img.shields.io/badge/Medium-fac31d)

[1765. Map of Highest Peak](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Searching%2FBreadth-First%20Search%2F1765.%20Map%20of%20Highest%20Peak): Given an `m x n` integer matrix `isWater` representing a map of water areas and land areas, return a matrix representing the height of the land at each cell.

### ![Difficulty: Hard](https://img.shields.io/badge/Hard-f8615c)

[0407. Trapping Rain Water II](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Searching/Breadth-First%20Search/0407.%20Trapping%20Rain%20Water%20II): Given an `m x n` matrix representing the height of each unit cell in a 2D elevation map, compute the volume of water it is able to trap after raining.

[1368. Minimum Cost to Make at Least One Valid Path in a Grid](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Searching/Breadth-First%20Search/1368.%20Minimum%20Cost%20to%20Make%20at%20Least%20One%20Valid%20Path%20in%20a%20Grid): Find the minimum cost to make at least one valid path from the top-left corner to the bottom-right corner of a grid.


