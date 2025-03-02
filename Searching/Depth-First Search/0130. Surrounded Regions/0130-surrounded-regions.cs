namespace LeetCodeSolutions.Searching/Depth-FirstSearch;

/*
 * 0130. Surrounded Regions
 * Difficulty: Medium
 * Submission Time: 2025-03-02 06:21:50
 * Created by vahtyah on 2025-03-02 06:23:41
*/
 
public class Solution {
    public void Solve(char[][] board) {
        if(board == null || board.Length < 1) return;
        var rows = board.Length;
        var cols = board[0].Length;

        for(int i = 0; i < cols; i++){
            if(board[0][i] == 'O') DFS(board, 0, i);
            if(board[rows - 1][i] == 'O') DFS(board, rows - 1, i);
        }

        for(int i = 0; i < rows; i++){
            if(board[i][0] == 'O') DFS(board, i, 0);
            if(board[i][cols - 1] == 'O') DFS(board, i, cols - 1);
        }

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (board[i][j] == 'O') {
                    board[i][j] = 'X';
                }
                else if (board[i][j] == 'A') {
                    board[i][j] = 'O';
                }
            }
        }
    }

    public void DFS(char[][] board, int i, int j){
        if(i < 0 || i >= board.Length || j < 0 || j >= board[0].Length || board[i][j] != 'O') return;
        board[i][j] = 'A';
        DFS(board, i + 1, j);
        DFS(board, i - 1, j);
        DFS(board, i, j + 1);
        DFS(board, i, j - 1);
    }
}