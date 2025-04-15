namespace LeetCodeSolutions.DataStructures/Tree/BinaryIndexTree;

/*
 * 2179. Count Good Triplets in an Array
 * Difficulty: Hard
 * Submission Time: 2025-04-15 04:47:03
 * Created by vahtyah on 2025-04-15 05:08:50
*/
 
public class Solution {
    public long GoodTriplets(int[] nums1, int[] nums2) {
        int n = nums1.Length;
        
        int[] pos = new int[n + 1];
        for (int i = 0; i < n; i++) {
            pos[nums2[i]] = i;
        }
        
        int[] mapped = new int[n];
        for (int i = 0; i < n; i++) {
            mapped[i] = pos[nums1[i]];
        }
        
        // Use a Binary Indexed Tree (Fenwick Tree) to count smaller elements
        BinaryIndexedTree bit = new BinaryIndexedTree(n);
        
        long result = 0;
        
        for (int j = 0; j < n; j++) {
            int smaller = bit.Query(mapped[j]);
            int larger = n - 1 - mapped[j] - (j - smaller);
            result += (long)smaller * larger;
            bit.Update(mapped[j] + 1, 1);
        }
        
        return result;
    }
    
    private class BinaryIndexedTree {
        private int[] tree;
        
        public BinaryIndexedTree(int size) {
            tree = new int[size + 1];
        }
        
        public void Update(int index, int val) {
            while (index < tree.Length) {
                tree[index] += val;
                index += index & -index; 
            }
        }
        
        public int Query(int index) {
            int sum = 0;
            while (index > 0) {
                sum += tree[index];
                index -= index & -index; 
            }
            return sum;
        }
    }
}