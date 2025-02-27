namespace LeetCodeSolutions.Searching/Depth-FirstSearch;

/*
 * 0112. Path Sum
 * Difficulty: Easy
 * Submission Time: 2025-02-27 20:35:46
 * Created by vahtyah on 2025-02-27 20:36:04
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
    public bool HasPathSum(TreeNode root, int targetSum) {
        if (root == null) return false;
        targetSum -= root.val;
        if (root.left == null && root.right == null) 
            return targetSum == 0;
        return HasPathSum(root.left, targetSum) || HasPathSum(root.right, targetSum);
    }
}