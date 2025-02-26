namespace LeetCodeSolutions.Recursion;

/*
 * 0106. Construct Binary Tree from Inorder and Postorder Traversal
 * Difficulty: Medium
 * Submission Time: 2025-02-26 16:38:17
 * Created by vahtyah on 2025-02-26 16:38:52
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
    public int[] mapInorder;
    public TreeNode BuildTree(int[] inorder, int[] postorder) {
        rootIdx = postorder.Length - 1;
        mapInorder = new int[6001];
        for(var i = 0; i < postorder.Length; i++) mapInorder[inorder[i] + 3000] = i;
        return BuildTree(inorder, postorder, 0, postorder.Length - 1);
    }
    public TreeNode BuildTree(int[] inorder, int[] postorder, int left, int right){
        if(left > right) return null;
        var mid = mapInorder[postorder[rootIdx] + 3000];
        var root = new TreeNode(postorder[rootIdx]);
        rootIdx--;
        root.right = BuildTree(inorder, postorder, mid + 1, right);
        root.left = BuildTree(inorder, postorder, left, mid - 1);
        return root;
    }
}