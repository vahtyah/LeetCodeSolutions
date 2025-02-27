namespace LeetCodeSolutions.Searching/Depth-FirstSearch;

/*
 * 0129. Sum Root to Leaf Numbers
 * Difficulty: Medium
 * Submission Time: 2025-02-27 21:01:36
 * Created by vahtyah on 2025-02-27 21:02:05
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
    public int SumNumbers(TreeNode root) {
        if(root == null) return 0;
        if(root.right == null && root.left == null) return root.val;
        if(root.right != null) root.right.val += root.val * 10;
        if(root.left != null) root.left.val += root.val * 10;
        return SumNumbers(root.left) + SumNumbers(root.right);
    }
}