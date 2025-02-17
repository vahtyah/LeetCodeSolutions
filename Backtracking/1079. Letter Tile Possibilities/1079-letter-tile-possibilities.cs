namespace LeetCodeSolutions.Backtracking;

/*
 * 1079. Letter Tile Possibilities
 * Difficulty: Medium
 * Submission Time: 2025-02-17 07:18:04
 * Created by vahtyah on 2025-02-17 07:18:46
*/

public class Solution {
    public int NumTilePossibilities(string tiles) {
        if(tiles.Length <= 1) return 1;
        var chars = tiles.ToCharArray();
        var permutations = new HashSet<string>();
        FindPermutations(chars, 0, permutations);
        return permutations.Count;
    }

    public void FindPermutations(char[] chars, int start, HashSet<string> permutations) {
        if(start == chars.Length){
            for(int i = 1; i <= chars.Length; i++){
                permutations.Add(new string(chars, 0, i));
            }
            return;
        }

        for(int i = start; i < chars.Length; i++){
            if(i != start && chars[i] == chars[start]) continue;
            Swap(chars, start, i);
            FindPermutations(chars, start + 1, permutations);
            Swap(chars, i, start);
        }
    }
    private void Swap(char[] chars, int i, int j) {
        if (i == j) return; 
        chars[i] ^= chars[j];
        chars[j] ^= chars[i];
        chars[i] ^= chars[j];
    }
}

public class Solution {
    public int NumTilePossibilities(string tiles) {
        if (string.IsNullOrEmpty(tiles)) return 0;
        if (tiles.Length == 1) return 1;
        
        // Count frequency of each character
        var freq = new int[26];
        foreach (char c in tiles) {
            freq[c - 'A']++;
        }
        
        // Use DFS to find all possible combinations
        return DFS(freq);
    }
    
    private int DFS(int[] freq) {
        int sum = 0;
        
        // Try using each available character
        for (int i = 0; i < 26; i++) {
            if (freq[i] == 0) continue;
            
            // Use this character
            freq[i]--;
            sum++;
            
            // Recursively find combinations using remaining characters
            sum += DFS(freq);
            
            // Backtrack
            freq[i]++;
        }
        
        return sum;
    }
}
 
public class Solution {
    private int count = -1;

    public int NumTilePossibilities(string tiles) {
        if(tiles.Length <= 1) return 1;
        var chars = tiles.ToCharArray();
        FindPermutations(chars);
        return count;
    }

    public void FindPermutations(char[] chars, int start = 0) {
        count++;
        for(int i = start; i < chars.Length; i++){
            if(IsDuplicate(chars, start, i)) continue;
            Swap(chars, start, i);
            FindPermutations(chars, start + 1);
            Swap(chars, i, start);
        }
    }

    private void Swap(char[] chars, int i, int j) {
        if (i == j) return; 
        chars[i] ^= chars[j];
        chars[j] ^= chars[i];
        chars[i] ^= chars[j];
    }

    private bool IsDuplicate(char[] chars, int start, int end) {
        for (int i = start; i < end; i++) {
            if (chars[i] == chars[end]) {
                return true;
            }
        }
        return false;
    }
}