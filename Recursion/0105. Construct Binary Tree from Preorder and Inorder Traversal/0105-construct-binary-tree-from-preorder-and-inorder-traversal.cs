namespace LeetCodeSolutions.Recursion;

/*
 * 0105. Construct Binary Tree from Preorder and Inorder Traversal
 * Difficulty: Medium
 * Submission Time: 2025-02-25 10:21:18
 * Created by vahtyah on 2025-02-25 10:49:39
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
    private Dictionary<int, int> inorderMap;

    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        if(preorder.Length == 0) return null;
        inorderMap = new Dictionary<int, int>();
        for (int i = 0; i < inorder.Length; i++) {
            inorderMap[inorder[i]] = i;
        }
        return Builder(preorder, 0, preorder.Length - 1, inorder, 0, inorder.Length - 1);
    }
    //Devide and Conquer
    public TreeNode Builder(int[] preorder, int preStart, int preEnd, int[] inorder, int inStart, int inEnd){
        if(preStart > preEnd || inStart > inEnd) return null;
        if(preStart == preEnd) return new TreeNode(preorder[preStart]);
        var rootIndex = inorderMap[preorder[preStart]];
        var leftSize = rootIndex - inStart;
        return new TreeNode(preorder[preStart], 
            Builder(preorder, preStart + 1, preStart + leftSize, inorder, inStart, rootIndex - 1),
            Builder(preorder, preStart + leftSize + 1, preEnd, inorder, rootIndex + 1, inEnd));
    }
}