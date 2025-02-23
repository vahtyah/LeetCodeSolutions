namespace LeetCodeSolutions.Searching/Breadth-FirstSearch;

/*
 * 0104. Maximum Depth of Binary Tree
 * Difficulty: Easy
 * Submission Time: 2025-02-23 13:04:43
 * Created by vahtyah on 2025-02-23 13:06:01
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
        if (root == null) return 0;
        
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);
        int depth = 0;
        int nextLevelCount = 0;
        int currentLevelCount = 1;  
        
        while (queue.Count > 0) {
            TreeNode current = queue.Dequeue();
            currentLevelCount--;
            
            if (current.left != null) {
                queue.Enqueue(current.left);
                nextLevelCount++;
            }
            if (current.right != null) {
                queue.Enqueue(current.right);
                nextLevelCount++;
            }
            
            if (currentLevelCount == 0) {
                depth++;
                currentLevelCount = nextLevelCount;
                nextLevelCount = 0;
            }
        }
        
        return depth;
    }
}