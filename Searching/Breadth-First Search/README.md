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

### ![Medium](https://img.shields.io/badge/Medium-fac31d)

[1462. Course Schedule IV](/Searching%2FBreadth-First%20Search%2F1462.%20Course%20Schedule%20IV): Check if a course is a prerequisite of another course.

[1765. Map of Highest Peak](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Searching%2FBreadth-First%20Search%2F1765.%20Map%20of%20Highest%20Peak): Find the highest peak on a map.

### ![Hard](https://img.shields.io/badge/Hard-f8615c)

[0407. Trapping Rain Water II](https://github.com/vahtyah/LeetCodeSolutions/blob/4f3480ea41349717ca90419670dfb22804f1f587/Searching/Breadth-First%20Search/0407.%20Trapping%20Rain%20Water%20II): Calculate the amount of water that can be trapped after raining.

[1368. Minimum Cost to Make at Least One Valid Path in a Grid](https://github.com/vahtyah/LeetCodeSolutions/blob/a1262282d89eae186573e94513b8cfe03a01fca7/Searching/Breadth-First%20Search/1368.%20Minimum%20Cost%20to%20Make%20at%20Least%20One%20Valid%20Path%20in%20a%20Grid): Find the minimum cost to make at least one valid path in a grid.

[2127. Maximum Employees to Be Invited to a Meeting](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Searching%2FBreadth-First%20Search%2F2127.%20Maximum%20Employees%20to%20Be%20Invited%20to%20a%20Meeting): Find the maximum number of employees to invite to a meeting.

[2493. Divide Nodes Into the Maximum Number of Groups](/Searching%2FBreadth-First%20Search%2F2493.%20Divide%20Nodes%20Into%20the%20Maximum%20Number%20of%20Groups): Divide nodes into the maximum number of groups.

