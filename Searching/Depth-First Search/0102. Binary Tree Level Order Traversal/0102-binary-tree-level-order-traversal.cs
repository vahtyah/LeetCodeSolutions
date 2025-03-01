namespace LeetCodeSolutions.Searching/Depth-FirstSearch;

/*
 * 0102. Binary Tree Level Order Traversal
 * Difficulty: Medium
 * Submission Time: 2025-03-01 09:13:50
 * Created by vahtyah on 2025-03-01 09:14:06
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
        var result = new List<IList<int>>(); 
        DFS(root, 0, result);
        return result;
    }

    public void DFS(TreeNode root, int level, List<IList<int>> result){
        if(root == null) return;

        if(level < result.Count) result[level].Add(root.val);
        else result.Add(new List<int>{ root.val });

        DFS(root.left, level + 1, result);
        DFS(root.right, level + 1, result);
    }
}