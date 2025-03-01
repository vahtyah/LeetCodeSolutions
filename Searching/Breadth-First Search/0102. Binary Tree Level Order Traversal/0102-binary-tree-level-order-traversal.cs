namespace LeetCodeSolutions.Searching/Breadth-FirstSearch;

/*
 * 0102. Binary Tree Level Order Traversal
 * Difficulty: Medium
 * Submission Time: 2025-03-01 09:09:10
 * Created by vahtyah on 2025-03-01 09:09:28
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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        if (root == null) return Array.Empty<IList<int>>();
        
        var result = new List<IList<int>>(20); 
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        
        while (queue.Count > 0) {
            int levelSize = queue.Count;
            int[] currentLevel = new int[levelSize];
            
            for (int i = 0; i < levelSize; i++) {
                TreeNode node = queue.Dequeue();
                currentLevel[i] = node.val;
                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }
            
            result.Add(currentLevel);
        }
        
        return result;
    }
}