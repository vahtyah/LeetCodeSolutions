namespace LeetCodeSolutions.Searching/Breadth-FirstSearch;

/*
 * 0909. Snakes and Ladders
 * Difficulty: Medium
 * Submission Time: 2025-05-03 06:58:18
 * Created by vahtyah on 2025-05-03 06:58:43
*/
 
public class Solution {
    public int SnakesAndLadders(int[][] board) {
        int n = board.Length;
        int target = n * n;
        
        Span<int> destinations = stackalloc int[target + 1];
        for (int num = 1; num <= target; num++) {
            int row = (num - 1) / n;
            int pos = (num - 1) % n;
            
            int rowIdx = n - 1 - row;
            int colIdx = row % 2 == 0 ? pos : n - 1 - pos;
            
            destinations[num] = board[rowIdx][colIdx];
        }

        Span<int> current = stackalloc int[target]; // Current level
        Span<int> next = stackalloc int[target];    // Next level
        Span<bool> visited = stackalloc bool[target + 1];
        
        current[0] = 1;
        visited[1] = true;
        int currentCount = 1;
        int nextCount = 0;
        
        int moves = 0;
        
        while (currentCount > 0) {
            for (int i = 0; i < currentCount; i++) {
                int pos = current[i];
                
                if (pos == target) return moves;
                
                for (int j = 1; j <= 6 && pos + j <= target; j++) {
                    int next_pos = pos + j;
                    
                    if (destinations[next_pos] != -1) {
                        next_pos = destinations[next_pos];
                    }
                    
                    if (!visited[next_pos]) {
                        next[nextCount++] = next_pos;
                        visited[next_pos] = true;
                    }
                }
            }
            
            var temp = current;
            current = next;
            next = temp;
            
            currentCount = nextCount;
            nextCount = 0;
            moves++;
        }
        
        return -1;
    }
}