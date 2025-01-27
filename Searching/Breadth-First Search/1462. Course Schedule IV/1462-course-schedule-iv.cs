namespace LeetCodeSolutions.Searching/Breadth-FirstSearch;

/*
 * 1462. Course Schedule IV
 * Difficulty: Medium
 * Created by vahtyah on 2025-01-27 11:04:28
 */

public class Solution {
    public IList<bool> CheckIfPrerequisite(int numCourses, int[][] prerequisites, int[][] queries) {
        List<int>[] graph = new List<int>[numCourses];
        HashSet<int>[] prerequisitesSet = new HashSet<int>[numCourses];
        
        for (int i = 0; i < numCourses; i++) {
            graph[i] = new List<int>();
            prerequisitesSet[i] = new HashSet<int>();
        }
        
        foreach (var pre in prerequisites) {
            graph[pre[0]].Add(pre[1]);
        }
        
        // Run BFS from each node to find all reachable nodes
        for (int i = 0; i < numCourses; i++) {
            var queue = new Queue<int>();
            var visited = new bool[numCourses];
            queue.Enqueue(i);
            
            while (queue.Count > 0) {
                int current = queue.Dequeue();
                foreach (int next in graph[current]) {
                    if (!visited[next]) {
                        visited[next] = true;
                        prerequisitesSet[next].Add(i);
                        prerequisitesSet[next].UnionWith(prerequisitesSet[current]);
                        queue.Enqueue(next);
                    }
                }
            }
        }
        
        var result = new List<bool>();
        foreach (var query in queries) {
            result.Add(prerequisitesSet[query[1]].Contains(query[0]));
        }
        
        return result;
    }
}