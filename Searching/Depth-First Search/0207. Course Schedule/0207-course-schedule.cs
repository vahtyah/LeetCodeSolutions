namespace LeetCodeSolutions.Searching/Depth-FirstSearch;

/*
 * 0207. Course Schedule
 * Difficulty: Medium
 * Submission Time: 2025-03-10 06:27:46
 * Created by vahtyah on 2025-03-10 06:28:09
*/
 
public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        List<List<int>> graph = new List<List<int>>();
        for (int i = 0; i < numCourses; i++) {
            graph.Add(new List<int>());
        }
        
        foreach (var prereq in prerequisites) {
            graph[prereq[0]].Add(prereq[1]);
        }
        
        // 0 = not visited, 1 = being visited (in current DFS path), 2 = completely visited
        Span<int> visited = stackalloc int[numCourses];
        
        for (int i = 0; i < numCourses; i++) {
            if (HasCycle(i, graph, ref visited)) {
                return false;  
            }
        }
        
        return true;  
    }
    
    private bool HasCycle(int node, List<List<int>> graph, ref Span<int> visited) {
        if (visited[node] == 1) return true;
        if (visited[node] == 2) return false;
        visited[node] = 1;
        
        foreach (int prerequisite in graph[node]) {
            if (HasCycle(prerequisite, graph, ref visited)) {
                return true;
            }
        }
        
        visited[node] = 2;
        return false;
    }
}