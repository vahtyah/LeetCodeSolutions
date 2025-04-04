namespace LeetCodeSolutions.Searching/Depth-FirstSearch;

/*
 * 1123. Lowest Common Ancestor of Deepest Leaves
 * Difficulty: Medium
 * Submission Time: 2025-04-04 05:43:28
 * Created by vahtyah on 2025-04-04 05:43:55
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
    public TreeNode LcaDeepestLeaves(TreeNode root) {
        if (root == null) return null;
        
        int leftDepth = GetDepth(root.left);
        int rightDepth = GetDepth(root.right);
        
        if (leftDepth == rightDepth) 
            return root;
        
        if (leftDepth > rightDepth) 
            return LcaDeepestLeaves(root.left);
        
        return LcaDeepestLeaves(root.right);
    }
    
    private int GetDepth(TreeNode node) {
        if (node == null) return 0;
        
        return 1 + Math.Max(GetDepth(node.left), GetDepth(node.right));
    }
}