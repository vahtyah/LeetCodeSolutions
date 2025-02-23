namespace LeetCodeSolutions.Searching/Depth-FirstSearch;

/*
 * 0101. Symmetric Tree
 * Difficulty: Easy
 * Submission Time: 2025-02-23 14:03:20
 * Created by vahtyah on 2025-02-23 14:03:39
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
    public bool IsSymmetric(TreeNode root) {
        return DFS(root.left, root.right);
    }

    public bool DFS(TreeNode left, TreeNode right){
        if(left == null && right == null) return true; 
        if(left == null || right == null || left.val != right.val) return false;
        return DFS(left.right, right.left) && DFS(left.left, right.right);
    }
}