# Sorting/Topological Sort

Topological Sort is a linear ordering of vertices in a directed acyclic graph (DAG) such that for every directed edge `uv` from vertex `u` to vertex `v`, `u` comes before `v` in the ordering. This is useful for scheduling tasks, resolving dependencies, and more.

## C# Implementation
```csharp
using System;
using System.Collections.Generic;

public class Graph
{
    private readonly int vertices;
    private readonly List<int>[] adjacencyList;

    public Graph(int v)
    {
        vertices = v;
        adjacencyList = new List<int>[vertices];
        for (int i = 0; i < vertices; i++)
        {
            adjacencyList[i] = new List<int>();
        }
    }

    public void AddEdge(int v, int w)
    {
        adjacencyList[v].Add(w);
    }

    public IEnumerable<int> TopologicalSort()
    {
        var stack = new Stack<int>();
        var visited = new bool[vertices];

        for (int i = 0; i < vertices; i++)
        {
            if (!visited[i])
            {
                TopologicalSortUtil(i, visited, stack);
            }
        }

        return stack;
    }

    private void TopologicalSortUtil(int v, bool[] visited, Stack<int> stack)
    {
        visited[v] = true;

        foreach (int neighbor in adjacencyList[v])
        {
            if (!visited[neighbor])
            {
                TopologicalSortUtil(neighbor, visited, stack);
            }
        }

        stack.Push(v);
    }

    public bool HasCycle()
    {
        var state = new int[vertices]; // 0 = unvisited, 1 = visiting, 2 = visited

        for (int i = 0; i < vertices; i++)
        {
            if (state[i] == 0 && IsCyclicUtil(i, state))
            {
                return true;
            }
        }

        return false;
    }

    private bool IsCyclicUtil(int v, int[] state)
    {
        if (state[v] == 1) return true; // Cycle detected
        if (state[v] == 2) return false; // Already processed

        state[v] = 1; // Mark as visiting

        foreach (int neighbor in adjacencyList[v])
        {
            if (IsCyclicUtil(neighbor, state))
            {
                return true;
            }
        }

        state[v] = 2; // Mark as visited
        return false;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var g = new Graph(6);
        g.AddEdge(5, 2);
        g.AddEdge(5, 0);
        g.AddEdge(4, 0);
        g.AddEdge(4, 1);
        g.AddEdge(2, 3);
        g.AddEdge(3, 1);

        if (g.HasCycle())
        {
            Console.WriteLine("Graph has a cycle. Topological sort is not possible.");
            return;
        }

        Console.WriteLine("Topological Sort of the graph is:");
        foreach (int vertex in g.TopologicalSort())
        {
            Console.Write(vertex + " ");
        }
        Console.WriteLine();
    }
}
```

## Solutions

### ![Medium](https://img.shields.io/badge/Medium-fac31d)

[0210. Course Schedule II](/Sorting%2FTopological%20Sort%2F0210.%20Course%20Schedule%20II): Find a valid course order given prerequisites

### ![Hard](https://img.shields.io/badge/Hard-f8615c)

[1857. Largest Color Value in a Directed Graph](/Sorting%2FTopological%20Sort%2F1857.%20Largest%20Color%20Value%20in%20a%20Directed%20Graph): Find maximum color value in directed graph with cycles
