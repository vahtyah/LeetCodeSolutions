public class Solution {
    private class Cell {
        public int Row { get; set; }
        public int Col { get; set; }
        public int Height { get; set; }
        
        public Cell(int row, int col, int height) {
            Row = row;
            Col = col;
            Height = height;
        }
    }
    
    public int TrapRainWater(int[][] heightMap) {
        if (heightMap == null || heightMap.Length < 3 || heightMap[0].Length < 3)
            return 0;
            
        int m = heightMap.Length;
        int n = heightMap[0].Length;
        
        var pq = new PriorityQueue<Cell, int>();
        bool[,] visited = new bool[m, n];
        
        // Add border cells to priority queue
        // Add top and bottom rows
        for (int i = 0; i < n; i++) {
            pq.Enqueue(new Cell(0, i, heightMap[0][i]), heightMap[0][i]);
            pq.Enqueue(new Cell(m-1, i, heightMap[m-1][i]), heightMap[m-1][i]);
            visited[0, i] = true;
            visited[m-1, i] = true;
        }
        
        // Add left and right columns
        for (int i = 1; i < m-1; i++) {
            pq.Enqueue(new Cell(i, 0, heightMap[i][0]), heightMap[i][0]);
            pq.Enqueue(new Cell(i, n-1, heightMap[i][n-1]), heightMap[i][n-1]);
            visited[i, 0] = true;
            visited[i, n-1] = true;
        }
        
        int[] dx = {-1, 0, 1, 0};
        int[] dy = {0, 1, 0, -1};
        int totalWater = 0;
        
        while (pq.Count > 0) {
            var cell = pq.Dequeue();
            
            for (int i = 0; i < 4; i++) {
                int newRow = cell.Row + dx[i];
                int newCol = cell.Col + dy[i];
                
                if (newRow < 0 || newRow >= m || newCol < 0 || newCol >= n || visited[newRow, newCol])
                    continue;
                    
                if (heightMap[newRow][newCol] < cell.Height) {
                    totalWater += cell.Height - heightMap[newRow][newCol];
                    pq.Enqueue(new Cell(newRow, newCol, cell.Height), cell.Height);
                } else {
                    pq.Enqueue(new Cell(newRow, newCol, heightMap[newRow][newCol]), heightMap[newRow][newCol]);
                }
                
                visited[newRow, newCol] = true;
            }
        }
        
        return totalWater;
    }
}

