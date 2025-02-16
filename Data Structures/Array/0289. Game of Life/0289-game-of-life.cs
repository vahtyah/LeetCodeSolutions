namespace LeetCodeSolutions.DataStructures/Array;

/*
 * 0289. Game of Life
 * Difficulty: Medium
 * Submission Time: 2025-02-16 08:42:44
 * Created by vahtyah on 2025-02-16 08:42:59
*/
 
public class Solution {
    private static readonly (int dx, int dy)[] Directions = {
        (-1, 0), (-1, 1), (0, 1), (1, 1),
        (1, 0), (1, -1), (0, -1), (-1, -1)
    };

    public void GameOfLife(int[][] board) {
        if (board == null || board.Length == 0 || board[0].Length == 0)
            return;

        int m = board.Length;
        int n = board[0].Length;

        // Use 2 to mark cells that become alive
        // Use -1 to mark cells that die
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                int liveNeighbors = CountLiveNeighbors(board, i, j);
                
                if (board[i][j] == 1) {
                    if (liveNeighbors < 2 || liveNeighbors > 3) {
                        board[i][j] = -1; 
                    }
                } else if (liveNeighbors == 3) {
                    board[i][j] = 2;
                }
            }
        }

        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (board[i][j] == -1) {
                    board[i][j] = 0;
                } else if (board[i][j] == 2) {
                    board[i][j] = 1;
                }
            }
        }
    }

    private int CountLiveNeighbors(int[][] board, int row, int col) {
        int count = 0;
        int m = board.Length;
        int n = board[0].Length;

        foreach (var (dx, dy) in Directions) {
            int newRow = row + dx;
            int newCol = col + dy;

            if (newRow >= 0 && newRow < m && newCol >= 0 && newCol < n) {
                count += (board[newRow][newCol] == 1 || board[newRow][newCol] == -1) ? 1 : 0;
            }
        }

        return count;
    }
}