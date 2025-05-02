namespace LeetCodeSolutions.Sorting/TopologicalSort;

/*
 * 0210. Course Schedule II
 * Difficulty: Medium
 * Submission Time: 2025-05-02 16:29:40
 * Created by vahtyah on 2025-05-02 16:31:04
*/
 
public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        var graph = new Graph(numCourses);
        foreach(var prere in prerequisites){
            graph.AddEdge(prere[0], prere[1]);
        }

        if(graph.HasCycle()) return new int[0];
        return graph.TopologicalSort();
    }
}

public class Graph{
    private int vertices;
    private List<int>[] adjacencyList;
    private int indexSortedArray = 0;

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

    private void TopologicalSortUtil(int v, bool[] visited, int[] sortedArray)
    {
        visited[v] = true;

        foreach (int i in adjacencyList[v])
        {
            if (!visited[i]) TopologicalSortUtil(i, visited, sortedArray);
        }

        sortedArray[indexSortedArray++] = v;
    }

    public int[] TopologicalSort()
    {
        var sortedArray = new int[vertices];
        var visited = new bool[vertices];
        
        for (int i = 0; i < vertices; i++)
        {
            if (!visited[i]) TopologicalSortUtil(i, visited, sortedArray);
        }

        return sortedArray;
    }

    public bool HasCycle()
    {
        bool[] visited = new bool[vertices];
        bool[] recStack = new bool[vertices];

        for (int i = 0; i < vertices; i++)
        {
            if (IsCyclicUtil(i, visited, recStack))
                return true;
        }
        return false;
    }

    private bool IsCyclicUtil(int v, bool[] visited, bool[] recStack)
    {
        if (!visited[v])
        {
            visited[v] = true;
            recStack[v] = true;

            foreach (int i in adjacencyList[v])
            {
                if (!visited[i] && IsCyclicUtil(i, visited, recStack))
                    return true;
                else if (recStack[i])
                    return true;
            }
        }
        recStack[v] = false;
        return false;
    }
}