namespace LeetCodeSolutions.Recursion/DivideandConquer;

/*
 * 0427. Construct Quad Tree
 * Difficulty: Medium
 * Submission Time: 2025-06-08 06:34:39
 * Created by vahtyah on 2025-06-08 06:34:59
*/
 
public class Solution {
    public Node Construct(int[][] grid) {
        return BuildQuadTree(grid, 0, 0, grid.Length);
    }

    private Node BuildQuadTree(int[][] grid, int row, int col, int len) {
        if (len == 1) {
            return new Node(grid[row][col] == 1, true);
        }
        
        int firstValue = grid[row][col];
        if (IsUniform(grid, row, col, len, firstValue)) {
            return new Node(firstValue == 1, true);
        }
        
        int quadLen = len >> 1;
        return new Node(false, false,
            BuildQuadTree(grid, row, col, quadLen),                    // topLeft
            BuildQuadTree(grid, row, col + quadLen, quadLen),          // topRight
            BuildQuadTree(grid, row + quadLen, col, quadLen),          // bottomLeft
            BuildQuadTree(grid, row + quadLen, col + quadLen, quadLen) // bottomRight
        );
    }
    
    private bool IsUniform(int[][] grid, int row, int col, int len, int expectedValue) {
        for (int i = row; i < row + len; i++) {
            for (int j = col; j < col + len; j++) {
                if (grid[i][j] != expectedValue) {
                    return false;
                }
            }
        }
        return true;
    }
}