namespace LeetCodeSolutions.Backtracking;

/*
 * 1980. Find Unique Binary String
 * Difficulty: Medium
 * Submission Time: 2025-02-20 05:53:17
 * Created by vahtyah on 2025-02-20 05:55:22
*/
 
public class Solution {
    public string FindDifferentBinaryString(string[] nums) {
        var n = nums.Length;
        var seen = new HashSet<string>(nums);
        var current = new char[n];
        Backtracking(0);
        return new string(current);

        bool Backtracking(int pos){
            if(pos == n)
                return !seen.Contains(new string(current));
            
            current[pos] = '0';
            if(Backtracking(pos + 1)) return true;
            current[pos] = '1';
            if(Backtracking(pos + 1)) return true;

            return false;
        }
    }
}

//Cantor's Diagonalization
public class Solution {
    public string FindDifferentBinaryString(string[] nums) {
        StringBuilder result = new StringBuilder();
        
        // Look at each diagonal position
        for (int i = 0; i < nums.Length; i++) {
            // Flip the bit at the diagonal
            char diagonalBit = nums[i][i];
            result.Append(diagonalBit == '0' ? '1' : '0');
        }
        
        return result.ToString();
    }
}