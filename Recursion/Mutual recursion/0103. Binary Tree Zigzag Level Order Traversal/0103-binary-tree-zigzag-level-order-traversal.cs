namespace LeetCodeSolutions.Recursion/Mutualrecursion;

/*
 * 0103. Binary Tree Zigzag Level Order Traversal
 * Difficulty: Medium
 * Submission Time: 2025-03-01 10:32:27
 * Created by vahtyah on 2025-03-01 10:34:07
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
        DFSEven(root, 0, result);
        return result;
    }
    
    private void DFSEven(TreeNode node, int level, List<IList<int>> result) {
        if (node == null) return;
        
        if(level < result.Count) result[level].Add(node.val);
        else result.Add(new List<int>{ node.val });
        
        DFSOdd(node.left, level + 1, result);
        DFSOdd(node.right, level + 1, result);
    }
    
    private void DFSOdd(TreeNode node, int level, List<IList<int>> result) {
        if (node == null) return;
        
        if(level < result.Count) result[level].Insert(0, node.val);
        else result.Add(new List<int>{ node.val });
        
        DFSEven(node.left, level + 1, result);
        DFSEven(node.right, level + 1, result);
    }
}