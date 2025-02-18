namespace LeetCodeSolutions.DataStructures/UnionFind;

/*
 * 0128. Longest Consecutive Sequence
 * Difficulty: Medium
 * Submission Time: 2025-02-18 18:22:55
 * Created by vahtyah on 2025-02-18 18:26:08
*/
 
public class Solution {
    private class UnionFind {
        private int[] parent;
        private int[] size;
        private int maxSize;

        public UnionFind(int n) {
            parent = new int[n];
            size = new int[n];
            maxSize = 1;
            
            for (int i = 0; i < n; i++) {
                parent[i] = i;
                size[i] = 1;
            }
        }

        public int Find(int x) {
            if (parent[x] != x) {
                parent[x] = Find(parent[x]);
            }
            return parent[x];
        }

        public void Union(int x, int y) {
            int rootX = Find(x);
            int rootY = Find(y);
            
            if (rootX != rootY) {
                parent[rootX] = rootY;
                size[rootY] += size[rootX];
                maxSize = Math.Max(maxSize, size[rootY]);
            }
        }

        public int GetMaxSize() {
            return maxSize;
        }
    }

    public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0) return 0;
        
        Dictionary<int, int> numToIndex = new Dictionary<int, int>();
        UnionFind uf = new UnionFind(nums.Length);

        for (int i = 0; i < nums.Length; i++) {
            if (numToIndex.ContainsKey(nums[i])) continue;
            numToIndex[nums[i]] = i;
            
            if (numToIndex.ContainsKey(nums[i] - 1)) {
                uf.Union(i, numToIndex[nums[i] - 1]);
            }
            if (numToIndex.ContainsKey(nums[i] + 1)) {
                uf.Union(i, numToIndex[nums[i] + 1]);
            }
        }

        return uf.GetMaxSize();
    }
}