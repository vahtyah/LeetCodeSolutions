namespace LeetCodeSolutions.DataStructures/UnionFind;

/*
 * 1061. Lexicographically Smallest Equivalent String
 * Difficulty: Medium
 * Submission Time: 2025-06-05 08:18:20
 * Created by vahtyah on 2025-06-05 08:18:38
*/
 
public class Solution {
    private int[] parent = new int[26];
    
    public Solution() {
        for (int i = 0; i < 26; i++) {
            parent[i] = i;
        }
    }
    
    private int Find(int x) {
        if (parent[x] != x) parent[x] = Find(parent[x]);
        return parent[x];
    }
    
    private void Union(int x, int y) {
        int rootX = Find(x);
        int rootY = Find(y);
        
        if (rootX == rootY) return;
        if (rootX < rootY) parent[rootY] = rootX;
        else parent[rootX] = rootY;
    }
    
    public string SmallestEquivalentString(string s1, string s2, string baseStr) {
        for (int i = 0; i < s1.Length; i++) {
            Union(s1[i] - 'a', s2[i] - 'a');
        }
        
        var result = new StringBuilder(baseStr.Length);
        for (int i = 0; i < baseStr.Length; i++) {
            result.Append((char)(Find(baseStr[i] - 'a') + 'a'));
        }
        
        return result.ToString();
    }
}