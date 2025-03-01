namespace LeetCodeSolutions.Searching/Depth-FirstSearch;

/*
 * 0098. Validate Binary Search Tree
 * Difficulty: Medium
 * Submission Time: 2025-03-01 20:03:17
 * Created by vahtyah on 2025-03-01 20:03:28
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
    public bool IsValidBST(TreeNode root) {
        return IsValidBSTHelper(root, long.MinValue, long.MaxValue);
    }
    
    private bool IsValidBSTHelper(TreeNode node, long min, long max) {
        if (node == null) return true;
        if (node.val <= min || node.val >= max) return false;
        
        return IsValidBSTHelper(node.left, min, node.val) && 
               IsValidBSTHelper(node.right, node.val, max);
    }
}