namespace LeetCodeSolutions.Pathfinding/Dijkstra'sAlgorithm;

/*
 * 3342. Find Minimum Time to Reach Last Room II
 * Difficulty: Medium
 * Submission Time: 2025-05-08 06:43:27
 * Created by vahtyah on 2025-05-08 06:44:03
*/
 
public class Solution {
    private static int[][] directions = new int[][]
    {
        new int[] {-1, 0},
        new int[] {0, -1},
        new int[] {1, 0},
        new int[] {0, 1}
    };

    public int MinTimeToReach(int[][] moveTime) {
        var m = moveTime.Length;
        var n = moveTime[0].Length;
        moveTime[0][0] = 0;

        var distance = new int[m, n];
        var visited = new bool[m, n];
        var pq = new PriorityQueue<(int row, int col, bool isEvenStep), int>();

        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++) distance[i, j] = int.MaxValue;
        }
        
        pq.Enqueue((0, 0, true), 0);
        distance[0, 0] = 0;

        while(pq.Count > 0){
            var (row, col, isEvenStep) = pq.Dequeue();

            if(visited[row, col]) continue;
            visited[row, col] = true;

            if(row == m - 1 && col == n - 1) return distance[row, col];

            foreach(var dir in directions){
                var newRow = row + dir[0];
                var newCol = col + dir[1];

                if(newRow < 0 || newRow >= m || newCol < 0 || newCol >= n || visited[newRow, newCol]) continue;

                var newDist = distance[row, col] + Math.Max(0, moveTime[newRow][newCol] - distance[row, col]) + (isEvenStep ? 1 : 2);
                if(newDist < distance[newRow, newCol]){
                    distance[newRow, newCol] = newDist;
                    pq.Enqueue((newRow, newCol, !isEvenStep), newDist);
                }
            }
        }
        return -1;
    }
}