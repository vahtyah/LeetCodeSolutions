namespace LeetCodeSolutions.Searching/Depth-FirstSearch;

/*
 * 0199. Binary Tree Right Side View
 * Difficulty: Medium
 * Submission Time: 2025-03-01 06:02:33
 * Created by vahtyah on 2025-03-01 06:02:52
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
        
        DFS(root, 0, result);
        return result;
    }
    
    private void DFS(TreeNode node, int level, List<int> result) {
        if (node == null) return;
        
        if (level == result.Count) {
            result.Add(node.val);
        }
        
        DFS(node.right, level + 1, result);
        DFS(node.left, level + 1, result);
    }
}