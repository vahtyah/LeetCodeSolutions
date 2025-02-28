namespace LeetCodeSolutions.Searching/Depth-FirstSearch;

/*
 * 0124. Binary Tree Maximum Path Sum
 * Difficulty: Hard
 * Submission Time: 2025-02-28 21:24:05
 * Created by vahtyah on 2025-02-28 21:26:58
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
    private int maxSum = int.MinValue;
    
    public int MaxPathSum(TreeNode root) {
        CalculateMaxPathSum(root);
        return maxSum;
    }
    
    private int CalculateMaxPathSum(TreeNode node) {
        if (node == null) {
            return 0;
        }
        
        int leftMax = Math.Max(0, CalculateMaxPathSum(node.left));
        int rightMax = Math.Max(0, CalculateMaxPathSum(node.right));
        maxSum = Math.Max(maxSum, node.val + leftMax + rightMax);
        
        return node.val + Math.Max(leftMax, rightMax);
    }
}