namespace LeetCodeSolutions.Recursion/Backtracking;

/*
 * 0079. Word Search
 * Difficulty: Medium
 * Submission Time: 2025-06-07 07:40:47
 * Created by vahtyah on 2025-06-07 07:41:07
*/
 
public class Solution {
    private static readonly int[][] directions = { 
        new int[] {-1, 0}, new int[] {1, 0}, new int[] {0, -1}, new int[] {0, 1}
    };

    public bool Exist(char[][] board, string word) {
        int n = board.Length;
        int m = board[0].Length;
        
        if (word.Length > n * m) return false;
        
        var boardCharCount = new int[128];
        var wordCharCount = new int[128];
        
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                boardCharCount[board[i][j]]++;
            }
        }
        
        foreach (char c in word) {
            wordCharCount[c]++;
            if (wordCharCount[c] > boardCharCount[c]) {
                return false; 
            }
        }
        
        // If the last char in boardCharCount is less than the first char, we can Reverser string to optimize performance
        bool searchReverse = ShouldSearchReverse(word, boardCharCount);
        if (searchReverse) {
            word = ReverseString(word);
        }
        
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                if (board[i][j] == word[0]) {
                    if(Backtrack(board, i, j, word, 0, n, m)) return true;
                }
            }
        }
        
        return false;
    }
    
    private bool ShouldSearchReverse(string word, int[] boardCharCount) {
        if (word.Length < 2) return false;
        
        char firstChar = word[0];
        char lastChar = word[word.Length - 1];
        
        return boardCharCount[lastChar] < boardCharCount[firstChar];
    }
    
    private string ReverseString(string str) {
        char[] chars = str.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
    
    private bool Backtrack(char[][] board, int row, int col, string word, int index, int n, int m) {
        if (index == word.Length - 1) return true;

        char original = board[row][col];
        board[row][col] = '#';

        char nextChar = word[index + 1];
        
        int newRow = row - 1;
        if (newRow >= 0 && board[newRow][col] == nextChar) {
            if (Backtrack(board, newRow, col, word, index + 1, n, m)) {
                board[row][col] = original;
                return true;
            }
        }
        
        newRow = row + 1;
        if (newRow < n && board[newRow][col] == nextChar) {
            if (Backtrack(board, newRow, col, word, index + 1, n, m)) {
                board[row][col] = original;
                return true;
            }
        }
        
        int newCol = col - 1;
        if (newCol >= 0 && board[row][newCol] == nextChar) {
            if (Backtrack(board, row, newCol, word, index + 1, n, m)) {
                board[row][col] = original;
                return true;
            }
        }
        
        newCol = col + 1;
        if (newCol < m && board[row][newCol] == nextChar) {
            if (Backtrack(board, row, newCol, word, index + 1, n, m)) {
                board[row][col] = original;
                return true;
            }
        }

        board[row][col] = original;
        return false;
    }
}