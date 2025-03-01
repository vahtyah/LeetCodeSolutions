namespace LeetCodeSolutions.Searching/Depth-FirstSearch;

/*
 * 0230. Kth Smallest Element in a BST
 * Difficulty: Medium
 * Submission Time: 2025-03-01 19:54:44
 * Created by vahtyah on 2025-03-01 19:55:10
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
    private int count = 0;
    private int result = 0;
    
    public int KthSmallest(TreeNode root, int k) {
        InorderTraversal(root, k);
        return result;
    }
    
    private void InorderTraversal(TreeNode node, int k) {
        if (node == null || count >= k) return;
        InorderTraversal(node.left, k);
        count++;
        if (count == k) {
            result = node.val;
            return;
        }
        InorderTraversal(node.right, k);
    }
}