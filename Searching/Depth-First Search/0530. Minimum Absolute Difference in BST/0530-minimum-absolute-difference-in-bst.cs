namespace LeetCodeSolutions.Searching/Depth-FirstSearch;

/*
 * 0530. Minimum Absolute Difference in BST
 * Difficulty: Easy
 * Submission Time: 2025-03-01 11:09:42
 * Created by vahtyah on 2025-03-01 11:12:07
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
    private int minDiff = int.MaxValue;
    private TreeNode prevNode = null;
    
    public int GetMinimumDifference(TreeNode root) {
        InorderTraversal(root);
        return minDiff;
    }
    
    private void InorderTraversal(TreeNode node) {
        if (node == null) return;
        InorderTraversal(node.left);
        if (prevNode != null) {
            minDiff = Math.Min(minDiff, Math.Abs(node.val - prevNode.val));
        }
        prevNode = node;
        InorderTraversal(node.right);
    }
}