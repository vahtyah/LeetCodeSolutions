namespace LeetCodeSolutions.Recursion/DivideandConquer;

/*
 * 0105. Construct Binary Tree from Preorder and Inorder Traversal
 * Difficulty: Medium
 * Submission Time: 2025-02-25 10:21:18
 * Created by vahtyah on 2025-03-01 07:40:13
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
    int i = 0;
    int p = 0;

    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        return CreateBranch(preorder, inorder, int.MinValue);
    }

    public TreeNode CreateBranch(int[] preorder, int[] inorder, int padre)
    {
        if (i >= preorder.Length || inorder[i] == padre)
        {
            i++;
            return null;
        }

        TreeNode nodo = new TreeNode(preorder[p]);

        int pre = preorder[p++];

        if (pre != inorder[i])
        {
            nodo.left = CreateBranch(preorder, inorder, nodo.val);
        }
        else
            i++;

        nodo.right = CreateBranch(preorder, inorder, padre);

        return nodo;
    }
}