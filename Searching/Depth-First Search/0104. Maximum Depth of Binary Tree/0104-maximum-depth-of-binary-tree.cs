namespace LeetCodeSolutions.Searching/Depth-FirstSearch;

/*
 * 0104. Maximum Depth of Binary Tree
 * Difficulty: Easy
 * Submission Time: 2025-02-23 13:00:29
 * Created by vahtyah on 2025-02-23 13:01:53
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
    public int MaxDepth(TreeNode root) {
        if(root == null) return 0;
        return Math.Max(1 + MaxDepth(root.left), 1 + MaxDepth(root.right));
    }
}