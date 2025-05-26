namespace LeetCodeSolutions.DynamicProgramming;

/*
 * 1857. Largest Color Value in a Directed Graph
 * Difficulty: Hard
 * Submission Time: 2025-05-26 06:39:54
 * Created by vahtyah on 2025-05-26 06:40:39
*/
 
public class Solution {
    public int LargestPathValue(string colors, int[][] edges) {
        int n = colors.Length;
        if(n == 0) return 0;
        if(edges.Length == 0) return 1;
        
        return GetLargestColor(colors, edges, n);
    }

    private int GetLargestColor(string colors, int[][] edges, int n) {
        var colorBytes = new byte[n];
        for(int i = 0; i < n; i++) {
            colorBytes[i] = (byte)(colors[i] - 'a');
        }
        
        var outDegree = new int[n];
        foreach(var edge in edges) {
            outDegree[edge[0]]++;
        }
        
        var adjList = new int[n][];
        var inDegree = new int[n];
        var adjIndex = new int[n];
        
        for(int i = 0; i < n; i++) {
            adjList[i] = new int[outDegree[i]];
        }
        
        foreach(var edge in edges) {
            int from = edge[0], to = edge[1];
            adjList[from][adjIndex[from]++] = to;
            inDegree[to]++;
        }
        
        var dp = new int[n << 5];
        var queue = new int[n];
        int head = 0, tail = 0;
        
        for(int i = 0; i < n; i++) {
            dp[(i << 5) + colorBytes[i]] = 1; 
            
            if(inDegree[i] == 0) {
                queue[tail++] = i;
            }
        }
        
        int processedNodes = 0;
        int maxColorValue = 0;
        
        while(head < tail) {
            int node = queue[head++];
            processedNodes++;
            
            int nodeBase = node << 5;
            
            for(int color = 0; color < 26; color++) {
                int value = dp[nodeBase + color];
                if(value > maxColorValue) {
                    maxColorValue = value;
                }
            }
            
            var neighbors = adjList[node];
            for(int i = 0; i < neighbors.Length; i++) {
                int neighbor = neighbors[i];
                int neighborBase = neighbor << 5;
                byte neighborColor = colorBytes[neighbor];
                
                for(int color = 0; color < 26; color++) {
                    int currentValue = dp[nodeBase + color];
                    if(currentValue > 0) {
                        int newValue = currentValue + (color == neighborColor ? 1 : 0);
                        if(newValue > dp[neighborBase + color]) {
                            dp[neighborBase + color] = newValue;
                        }
                    }
                }
                
                if(--inDegree[neighbor] == 0) {
                    queue[tail++] = neighbor;
                }
            }
        }
        
        return processedNodes == n ? maxColorValue : -1;
    }
}