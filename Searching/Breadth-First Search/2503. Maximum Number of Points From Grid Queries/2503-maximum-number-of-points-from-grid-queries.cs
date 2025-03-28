namespace LeetCodeSolutions.Searching/Breadth-FirstSearch;

/*
 * 2503. Maximum Number of Points From Grid Queries
 * Difficulty: Hard
 * Submission Time: 2025-03-28 04:52:44
 * Created by vahtyah on 2025-03-28 05:17:24
*/
 
public class Solution {
    public int[] MaxPoints(int[][] grid, int[] queries) {
        int m = grid.Length, n = grid[0].Length, k = queries.Length;
        (int dx, int dy)[] dirs = [(0, 1), (0, -1), (1, 0), (-1, 0)];
        
        var queryWithIndex = new int[k][];
        for(int i = 0; i < k; i++) {
            queryWithIndex[i] = [queries[i], i];
        }
        Array.Sort(queryWithIndex, (a, b) => a[0] - b[0]);

        var pq = new PriorityQueue<int[], int>();  // [value, row, col]
        pq.Enqueue([grid[0][0], 0, 0], grid[0][0]);
        grid[0][0] = 0; // Mark as visited
        
        var answer = new int[k];
        var count = 0;

        foreach(var qi in queryWithIndex) {
            int query = qi[0], index = qi[1];
            
            while(pq.Count > 0 && pq.Peek()[0] < query) {
                var current = pq.Dequeue();
                int row = current[1], col = current[2];
                count++;

                foreach(var (dx, dy) in dirs) {
                    int newRow = row + dx, newCol = col + dy;
                    
                    if(newRow < 0 || newCol < 0 || newRow >= m || newCol >= n || grid[newRow][newCol] == 0) 
                        continue;
                    
                    pq.Enqueue([grid[newRow][newCol], newRow, newCol], grid[newRow][newCol]);
                    grid[newRow][newCol] = 0; 
                }
            }

            answer[index] = count;
        }

        return answer;
    }
}