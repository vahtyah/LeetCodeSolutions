namespace LeetCodeSolutions.Pathfinding/Dijkstra'sAlgorithm;

/*
 * 3341. Find Minimum Time to Reach Last Room I
 * Difficulty: Medium
 * Submission Time: 2025-05-07 07:10:01
 * Created by vahtyah on 2025-05-07 07:10:29
*/
 
public class Solution {
    private static int[][] directions = new int[][] 
    {
        new int[] {0, 1},
        new int[] {1, 0},
        new int[] {0, -1},
        new int[] {-1, 0}
    };

    public int MinTimeToReach(int[][] moveTime) {
        var m = moveTime.Length;
        var n = moveTime[0].Length;
        moveTime[0][0] = 0;

        var distance = new int[m, n];
        var visited = new bool[m, n];

        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++) distance[i, j] = int.MaxValue;
        }

        distance[0, 0] = 0;

        var pq = new PriorityQueue<(int row, int col), int>(m * n);
        pq.Enqueue((0, 0), 0);

        while(pq.Count > 0){
            var (row, col) = pq.Dequeue();

            if(row == m - 1 && col == n - 1) return distance[row, col];

            foreach(var dir in directions){
                var newRow = row + dir[0];
                var newCol = col + dir[1];

                if(newRow < 0 || newRow >= m || newCol < 0 || newCol >= n || visited[newRow, newCol]) continue;

                var newDist = distance[row, col] + 1 + Math.Max(0, moveTime[newRow][newCol] - distance[row, col]);
                if(newDist < distance[newRow, newCol]){
                    distance[newRow, newCol] = newDist;
                    pq.Enqueue((newRow, newCol), newDist);
                }
                visited[newRow, newCol] = true;
            }
        }

        return -1;
    }
}