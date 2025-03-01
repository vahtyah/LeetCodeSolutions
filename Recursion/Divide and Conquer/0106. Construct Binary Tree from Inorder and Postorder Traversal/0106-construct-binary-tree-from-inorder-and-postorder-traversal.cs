namespace LeetCodeSolutions.Recursion/DivideandConquer;

/*
 * 0106. Construct Binary Tree from Inorder and Postorder Traversal
 * Difficulty: Medium
 * Submission Time: 2025-02-26 16:38:17
 * Created by vahtyah on 2025-03-01 07:40:57
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
    public int rootIdx;
    public TreeNode BuildTree(int[] inorder, int[] postorder) {
        rootIdx = postorder.Length - 1;
        return BuildTree(inorder, postorder, 0, postorder.Length - 1);
    }
    public TreeNode BuildTree(int[] inorder, int[] postorder, int left, int right){
        if(left > right) return null;
        var mid = right;
        while(inorder[mid] != postorder[rootIdx]){
            mid--;
        }
        var root = new TreeNode(postorder[rootIdx]);
        rootIdx--;
        root.right = BuildTree(inorder, postorder, mid + 1, right);
        root.left = BuildTree(inorder, postorder, left, mid - 1);
        return root;
    }
}