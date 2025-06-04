namespace LeetCodeSolutions.DataStructures/Trie;

/*
 * 0212. Word Search II
 * Difficulty: Hard
 * Submission Time: 2025-06-04 21:32:40
 * Created by vahtyah on 2025-06-04 21:42:31
*/
 
public class Solution {
    public class Trie {
        public Trie[] Children = new Trie[26];
        public string Word;
        public int Refs;
    }

    private static readonly int[][] directions = {
        new int[]{0, -1}, new int[]{0, 1}, 
        new int[]{1, 0}, new int[]{-1, 0}
    };
    
    private Trie root = new Trie();

    private void InsertWord(string word) {
        var node = root;
        node.Refs++; 
        
        foreach (var c in word) {
            var index = c - 'a';
            if (node.Children[index] == null) {
                node.Children[index] = new Trie();
            }
            node = node.Children[index];
            node.Refs++; 
        }
        node.Word = word; 
    }

    public IList<string> FindWords(char[][] board, string[] words) {
        var m = board.Length;
        var n = board[0].Length;

        foreach (var word in words) {
            InsertWord(word);
        }

        var result = new List<string>();
        
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                var charIndex = board[i][j] - 'a';
                if (root.Children[charIndex] != null) {
                    DFS(i, j, board, root.Children[charIndex], result);
                }
            }
        }

        return result;
    }

    private void DFS(int row, int col, char[][] board, Trie node, List<string> result) {
        var originalChar = board[row][col];
        
        board[row][col] = '#';

        if (node.Word != null) {
            result.Add(node.Word);
            node.Word = null;
            node.Refs--;
        }

        foreach (var dir in directions) {
            var newRow = row + dir[0];
            var newCol = col + dir[1];
            
            if (newRow < 0 || newRow >= board.Length || 
                newCol < 0 || newCol >= board[0].Length || 
                board[newRow][newCol] == '#') {
                continue;
            }
            
            var charIndex = board[newRow][newCol] - 'a';
            var childNode = node.Children[charIndex];
            
            if (childNode != null && childNode.Refs > 0) {
                DFS(newRow, newCol, board, childNode, result);
            }
        }

        board[row][col] = originalChar;
    }
}