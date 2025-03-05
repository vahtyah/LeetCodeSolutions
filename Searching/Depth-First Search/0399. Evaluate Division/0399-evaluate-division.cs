namespace LeetCodeSolutions.Searching/Depth-FirstSearch;

/*
 * 0399. Evaluate Division
 * Difficulty: Medium
 * Submission Time: 2025-03-05 05:21:32
 * Created by vahtyah on 2025-03-05 05:23:29
*/
 
public class Solution 
{
    public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries)
    {
        var graph = new Dictionary<string, Dictionary<string, double>>();
        
        for (int i = 0; i < equations.Count; i++)
        {
            var dividend = equations[i][0];
            var divisor = equations[i][1];
            var quotient = values[i];

            if (!graph.ContainsKey(dividend))
                graph[dividend] = new Dictionary<string, double>();
            graph[dividend][divisor] = quotient;

            if (!graph.ContainsKey(divisor))
                graph[divisor] = new Dictionary<string, double>();
            graph[divisor][dividend] = 1.0 / quotient;
        }

        var result = new double[queries.Count];
        for (int i = 0; i < queries.Count; i++)
        {
            var start = queries[i][0];
            var end = queries[i][1];

            if (!graph.ContainsKey(start) || !graph.ContainsKey(end))
            {
                result[i] = -1.0;
                continue;
            }

            result[i] = DFS(start, end, new HashSet<string>(), graph);
        }

        return result;
    }

    private double DFS(string current, string target, HashSet<string> visited, Dictionary<string, Dictionary<string, double>> graph)
    {
        if (current == target) 
            return 1.0;

        visited.Add(current);
        
        foreach (var neighbor in graph[current])
        {
            if (!visited.Contains(neighbor.Key))
            {
                var product = DFS(neighbor.Key, target, visited, graph);
                if (product != -1.0)
                    return product * neighbor.Value;
            }
        }

        return -1.0;
    }
}