namespace LeetCodeSolutions.Searching/Breadth-FirstSearch;

/*
 * 0101. Symmetric Tree
 * Difficulty: Easy
 * Submission Time: 2025-02-23 14:13:42
 * Created by vahtyah on 2025-02-23 14:14:00
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
        if (root == null) return true;
        
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root.left);
        queue.Enqueue(root.right);
        
        while (queue.Count > 0) {
            var leftNode = queue.Dequeue();
            var rightNode = queue.Dequeue();
            
            if (leftNode == null && rightNode == null) continue;
            if (leftNode == null || rightNode == null) return false;
            if (leftNode.val != rightNode.val) return false;
            
            queue.Enqueue(leftNode.left);
            queue.Enqueue(rightNode.right);
            
            queue.Enqueue(leftNode.right);
            queue.Enqueue(rightNode.left);
        }
        
        return true;
    }
}