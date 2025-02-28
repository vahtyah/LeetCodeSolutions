namespace LeetCodeSolutions.Searching/Depth-FirstSearch;

/*
 * 0222. Count Complete Tree Nodes
 * Difficulty: Easy
 * Submission Time: 2025-02-28 16:11:43
 * Created by vahtyah on 2025-02-28 16:13:10
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
    public int CountNodes(TreeNode root) {
        if(root == null) return 0;
        return CountNodes(root.left) + CountNodes(root.right) + 1;
    }
}

public class Solution {
    public int CountNodes(TreeNode root) {
        if (root == null) return 0;
        
        int leftHeight = 0, rightHeight = 0;
        TreeNode left = root, right = root;
        
        while (left != null) {
            leftHeight++;
            left = left.left;
        }
        
        while (right != null) {
            rightHeight++;
            right = right.right;
        }
        
        if (leftHeight == rightHeight) {
            return (1 << leftHeight) - 1; // 2^h - 1 nodes
        }
        
        return 1 + CountNodes(root.left) + CountNodes(root.right);
    }
}