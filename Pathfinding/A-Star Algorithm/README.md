# A* Algorithm

The **A\* (A-star) algorithm** is a popular pathfinding algorithm used to find the shortest path between two points in a graph. It is an extension of Dijkstra's algorithm with a heuristic function that guides the search towards the goal efficiently.

## Key Concepts

1. **Input:** A graph with nodes and edges, a start node, and a goal node.
2. **Output:** The shortest path from the start node to the goal node.
3. **Logic:**
   - Initialize an open list to store nodes to be explored and a closed list to store nodes that have been visited.
   - Add the start node to the open list.
   - While the open list is not empty:
     - Select the node with the lowest cost (f-score) from the open list.
     - If the selected node is the goal node, reconstruct the path and return it.
     - Generate the neighbors of the selected node and calculate their costs.
     - For each neighbor:
       - If the neighbor is in the closed list and has a lower cost, skip it.
       - If the neighbor is not in the open list, add it to the open list.
       - If the neighbor is in the open list and has a lower cost, update its cost.
   - If the open list is empty and the goal node has not been reached, there is no path.
   - Return the shortest path from the start node to the goal node.

4. The A\* algorithm uses two cost functions:
   - **g(n):** The cost of the path from the start node to node n.
   - **h(n):** The heuristic function that estimates the cost from node n to the goal node.
   - **f(n) = g(n) + h(n):** The total estimated cost of the path through node n.

5. Time complexity: O(b^d), where b is the branching factor and d is the depth of the solution.

## C# Implementation

```csharp
public class AStarNode
{
    public int X { get; set; }
    public int Y { get; set; }
    public int G { get; set; }
    public int H { get; set; }
    public int F => G + H;
    public AStarNode Parent { get; set; }

    public AStarNode(int x, int y, int g, int h, AStarNode parent)
    {
        X = x;
        Y = y;
        G = g;
        H = h;
        Parent = parent;
    }
}

public class AStarAlgorithm
{
    public static List<(int, int)> FindShortestPath(int[,] grid, (int, int) start, (int, int) goal)
    {
        int rows = grid.GetLength(0);
        int cols = grid.GetLength(1);
        int[,] directions = { { 0, 1 }, { 0, -1 }, { 1, 0 }, { -1, 0 } };
        HashSet<(int, int)> closedSet = new HashSet<(int, int)>();
        PriorityQueue<AStarNode> openSet = new PriorityQueue<AStarNode>();
        AStarNode startNode = new AStarNode(start.Item1, start.Item2, 0, Heuristic(start, goal), null);
        openSet.Enqueue(startNode, startNode.F);

        while (openSet.Count > 0)
        {
            AStarNode current = openSet.Dequeue();
            if ((current.X, current.Y) == goal)
            {
                return ReconstructPath(current);
            }

            closedSet.Add((current.X, current.Y));

            foreach (int[] dir in directions)
            {
                int newX = current.X + dir[0];
                int newY = current.Y + dir[1];

                if (newX < 0 || newX >= rows || newY < 0 || newY >= cols || grid[newX, newY] == 1 || closedSet.Contains((newX, newY)))
                {
                    continue;
                }

                int newG = current.G + 1;
                int newH = Heuristic((newX, newY), goal);
                AStarNode neighbor = new AStarNode(newX, newY, newG, newH, current);

                if (!openSet.Contains(neighbor))
                {
                    openSet.Enqueue(neighbor, neighbor.F);
                }
            }
        }

        return new List<(int, int)>();
    }

    private static int Heuristic((int, int) current, (int, int) goal)
    {
        return Math.Abs(current.Item1 - goal.Item1) + Math.Abs(current.Item2 - goal.Item2);
    }

    private static List<(int, int)> ReconstructPath(AStarNode node)
    {
        List<(int, int)> path = new List<(int, int)>();
        while (node != null)
        {
            path.Add((node.X, node.Y));
            node = node.Parent;
        }
        path.Reverse();
        return path;
    }
}

```

[//]: # (## Solutions)

[//]: # (### ![Easy]&#40;https://img.shields.io/badge/Easy-46c6c2&#41;)

[//]: # (### ![Medium]&#40;https://img.shields.io/badge/Medium-fac31d&#41;)
