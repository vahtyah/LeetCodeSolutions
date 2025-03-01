namespace LeetCodeSolutions.Searching/Depth-FirstSearch;

/*
 * 0103. Binary Tree Zigzag Level Order Traversal
 * Difficulty: Medium
 * Submission Time: 2025-03-01 10:39:40
 * Created by vahtyah on 2025-03-01 10:40:01
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
        DFS(root, 0, result);
        return result;
    }
    
    private void DFS(TreeNode node, int level, List<IList<int>> result) {
        if (node == null) return;

        if(level >= result.Count) result.Add(new List<int>{ node.val });
        else if((level & 1) == 0) result[level].Add(node.val);
        else result[level].Insert(0, node.val);
        
        DFS(node.left, level + 1, result);
        DFS(node.right, level + 1, result);
    }
}