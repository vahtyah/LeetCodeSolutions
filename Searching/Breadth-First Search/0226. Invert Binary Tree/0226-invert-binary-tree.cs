namespace LeetCodeSolutions.Searching/Breadth-FirstSearch;

/*
 * 0226. Invert Binary Tree
 * Difficulty: Easy
 * Submission Time: 2025-02-23 13:56:43
 * Created by vahtyah on 2025-02-23 13:57:28
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
        if (root == null) return null;
        
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        
        while (queue.Count > 0) {
            var current = queue.Dequeue();
            
            var temp = current.left;
            current.left = current.right;
            current.right = temp;
            
            if (current.left != null) {
                queue.Enqueue(current.left);
            }
            if (current.right != null) {
                queue.Enqueue(current.right);
            }
        }
        
        return root;
    }
}