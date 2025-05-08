# Dijkstra's Algorithm

The **Dijkstra's Algorithm** is a popular algorithm used to find the shortest path from a start node to all other nodes in a weighted graph. It works by maintaining a priority queue of nodes to be explored and updating the shortest distance to each node as it explores the graph.

## Key Concepts

1. **Input:** A weighted graph represented as an adjacency list or matrix, a start node, and an end node.
2. **Output:** The shortest path from the start node to the end node.
3. **Logic:**
   - Initialize a priority queue to store nodes to be explored, with the start node as the first element.
   - Initialize a distance array to store the shortest distance to each node from the start node.
   - While the priority queue is not empty, dequeue the node with the shortest distance.
   - For each neighbor of the current node, update the distance if a shorter path is found.
   - Add the neighbor to the priority queue if its distance is updated.
   - Continue exploring nodes until the end node is reached.
   - Return the shortest path from the start node to the end node.
   - If the end node is not reachable, return an empty path.
4. **Time complexity:** `O((V + E) log V)`, where `V` is the number of vertices and `E` is the number of edges in the graph.

## C# Implementation

```csharp
public class Dijkstra
{
    public int[] ShortestPath(int[][] graph, int start, int end)
    {
        int n = graph.Length;
        int[] distance = new int[n];
        Array.Fill(distance, int.MaxValue);
        distance[start] = 0;

        PriorityQueue<int> pq = new PriorityQueue<int>();
        pq.Enqueue(start, 0);

        while (pq.Count > 0)
        {
            int node = pq.Dequeue();
            if (node == end)
            {
                break;
            }

            foreach (int[] edge in graph[node])
            {
                int neighbor = edge[0];
                int weight = edge[1];

                if (distance[node] + weight < distance[neighbor])
                {
                    distance[neighbor] = distance[node] + weight;
                    pq.Enqueue(neighbor, distance[neighbor]);
                }
            }
        }

        return distance;
    }
}
```

## Solutions

### ![Medium](https://img.shields.io/badge/Medium-fac31d)

[1976. Number of Ways to Arrive at Destination](/Pathfinding%2FDijkstra%27s%20Algorithm%2F1976.%20Number%20of%20Ways%20to%20Arrive%20at%20Destination): Find the number of shortest paths to destination node

[3341. Find Minimum Time to Reach Last Room I](/Pathfinding%2FDijkstra%27s%20Algorithm%2F3341.%20Find%20Minimum%20Time%20to%20Reach%20Last%20Room%20I): Minimize time to visit rooms sequentially with delay

[3342. Find Minimum Time to Reach Last Room II](/Pathfinding%2FDijkstra%27s%20Algorithm%2F3342.%20Find%20Minimum%20Time%20to%20Reach%20Last%20Room%20II): Minimize time to visit rooms sequentially with delay
