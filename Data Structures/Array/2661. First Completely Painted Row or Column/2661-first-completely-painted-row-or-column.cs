public class Solution {
    public int FirstCompleteIndex(int[] arr, int[][] mat) {
        var m = mat.Length;
        var n = mat[0].Length;
        
        var rowCounts = new int[m];
        var colCounts = new int[n];
        
        var positions = new (int row, int col)[arr.Length + 1];
        
        for(int i = 0; i < m; i++) {
            for(int j = 0; j < n; j++) {
                positions[mat[i][j]] = (i, j);
            }
        }
        
        for(int i = 0; i < arr.Length; i++) {
            var (row, col) = positions[arr[i]];
            
            if(++rowCounts[row] == n || ++colCounts[col] == m) {
                return i;
            }
        }
        
        return -1;
    }
}