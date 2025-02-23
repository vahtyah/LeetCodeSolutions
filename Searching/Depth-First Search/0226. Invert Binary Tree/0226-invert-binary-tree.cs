namespace LeetCodeSolutions.Searching/Depth-FirstSearch;

/*
 * 0226. Invert Binary Tree
 * Difficulty: Easy
 * Submission Time: 2025-02-23 13:51:17
 * Created by vahtyah on 2025-02-23 13:51:57
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
    public TreeNode InvertTree(TreeNode root) {
        if(root == null) return null;
        return new TreeNode(root.val, InvertTree(root.right), InvertTree(root.left));
    }
}