namespace LeetCodeSolutions.Searching/Breadth-FirstSearch;

/*
 * 0103. Binary Tree Zigzag Level Order Traversal
 * Difficulty: Medium
 * Submission Time: 2025-03-01 10:24:44
 * Created by vahtyah on 2025-03-01 10:25:12
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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        var result = new List<IList<int>>();
        
        if (root == null) {
            return result;
        }
        
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        bool isLeftToRight = true;
        
        while (queue.Count > 0) {
            int levelSize = queue.Count;
            var currentLevel = new List<int>();
            
            for (int i = 0; i < levelSize; i++) {
                TreeNode node = queue.Dequeue();
                currentLevel.Add(node.val);
                
                if (node.left != null) {
                    queue.Enqueue(node.left);
                }
                if (node.right != null) {
                    queue.Enqueue(node.right);
                }
            }
            
            if (!isLeftToRight) {
                currentLevel.Reverse();
            }
            result.Add(currentLevel);
            isLeftToRight = !isLeftToRight;
        }
        
        return result;
    }
}