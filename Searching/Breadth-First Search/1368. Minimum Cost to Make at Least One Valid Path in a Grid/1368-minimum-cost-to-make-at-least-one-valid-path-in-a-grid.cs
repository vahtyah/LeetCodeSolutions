public class Solution {
    private readonly int[][] directions = new int[][] {
        new int[] {0, 1},  // right (1)
        new int[] {0, -1}, // left  (2)
        new int[] {1, 0},  // down  (3)
        new int[] {-1, 0}  // up    (4)
    };
    
    public int MinCost(int[][] grid) {
        int m = grid.Length;
        int n = grid[0].Length;
        
        bool[,] visited = new bool[m, n];
        var deque = new LinkedList<(int row, int col, int cost)>();
        deque.AddFirst((0, 0, 0));
        
        while (deque.Count > 0) {
            var (row, col, cost) = deque.First.Value;
            deque.RemoveFirst();
            
            if (visited[row, col]) continue;
            visited[row, col] = true;
            
            if (row == m - 1 && col == n - 1) {
                return cost;
            }
            
            for (int i = 0; i < 4; i++) {
                int newRow = row + directions[i][0];
                int newCol = col + directions[i][1];
                
                if (newRow >= 0 && newRow < m && newCol >= 0 && newCol < n && !visited[newRow, newCol]) {
                    if (grid[row][col] == i + 1) {
                        deque.AddFirst((newRow, newCol, cost));
                    }
                    else {
                        deque.AddLast((newRow, newCol, cost + 1));
                    }
                }
            }
        }
        
        return 0; 
    }
}