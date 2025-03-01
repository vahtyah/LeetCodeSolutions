namespace LeetCodeSolutions.Searching/Depth-FirstSearch;

/*
 * 0637. Average of Levels in Binary Tree
 * Difficulty: Easy
 * Submission Time: 2025-03-01 06:31:51
 * Created by vahtyah on 2025-03-01 06:32:14
*/
 
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<double> AverageOfLevels(TreeNode root) {
        if (root == null) return new List<double>();
        
        var sums = new List<double>();    
        var counts = new List<int>();     
        
        DFS(root, 0, sums, counts);
        
        for (int i = 0; i < sums.Count; i++) {
            sums[i] = sums[i] / counts[i];
        }
        
        return sums;
    }
    
    private void DFS(TreeNode node, int level, List<double> sums, List<int> counts) {
        if (node == null) return;
        
        if (level == sums.Count) {
            sums.Add(node.val);
            counts.Add(1);
        } else {
            sums[level] += node.val;
            counts[level]++;
        }
        
        DFS(node.left, level + 1, sums, counts);
        DFS(node.right, level + 1, sums, counts);
    }
}