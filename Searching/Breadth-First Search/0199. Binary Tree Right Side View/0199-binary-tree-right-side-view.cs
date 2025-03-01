namespace LeetCodeSolutions.Searching/Breadth-FirstSearch;

/*
 * 0199. Binary Tree Right Side View
 * Difficulty: Medium
 * Submission Time: 2025-03-01 06:03:57
 * Created by vahtyah on 2025-03-01 06:04:18
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
    public IList<int> RightSideView(TreeNode root) {
        List<int> result = new List<int>();
        if (root == null) return result;
        
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        
        while (queue.Count > 0) {
            int levelSize = queue.Count;
            
            for (int i = 0; i < levelSize; i++) {
                TreeNode current = queue.Dequeue();
                
                if (i == levelSize - 1) {
                    result.Add(current.val);
                }
                
                if (current.left != null) {
                    queue.Enqueue(current.left);
                }
                if (current.right != null) {
                    queue.Enqueue(current.right);
                }
            }
        }
        
        return result;
    }
}