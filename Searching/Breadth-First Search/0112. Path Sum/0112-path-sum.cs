namespace LeetCodeSolutions.Searching/Breadth-FirstSearch;

/*
 * 0112. Path Sum
 * Difficulty: Easy
 * Submission Time: 2025-02-27 20:37:23
 * Created by vahtyah on 2025-02-27 20:37:42
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
        
        var queue = new Queue<(TreeNode, int)>();
        queue.Enqueue((root, root.val));
        
        while (queue.Count > 0) {
            var (node, currentSum) = queue.Dequeue();
            
            if (node.left == null && node.right == null && currentSum == targetSum) {
                return true;
            }
            
            if (node.left != null) {
                queue.Enqueue((node.left, currentSum + node.left.val));
            }
            
            if (node.right != null) {
                queue.Enqueue((node.right, currentSum + node.right.val));
            }
        }
        
        return false;
    }
}