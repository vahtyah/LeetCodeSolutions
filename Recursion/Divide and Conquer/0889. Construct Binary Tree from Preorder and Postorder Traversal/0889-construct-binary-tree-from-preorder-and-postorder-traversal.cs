namespace LeetCodeSolutions.Recursion/DivideandConquer;

/*
 * 0889. Construct Binary Tree from Preorder and Postorder Traversal
 * Difficulty: Medium
 * Submission Time: 2025-02-23 10:27:51
 * Created by vahtyah on 2025-03-01 07:41:14
*/
 
public class Solution {
    public TreeNode ConstructFromPrePost(int[] preorder, int[] postorder) {
        if (preorder.Length == 0) return null;
        return ConstructHelper(preorder, 0, preorder.Length - 1, postorder, 0, postorder.Length - 1);
    }

    private TreeNode ConstructHelper(int[] preorder, int preStart, int preEnd, int[] postorder, int postStart, int postEnd) {
        if (preStart > preEnd || postStart > postEnd) return null;
        if (preStart == preEnd) return new TreeNode(preorder[preStart]);
        int leftRoot = preorder[preStart + 1];
        int leftRootIndex = postStart;
        while (postorder[leftRootIndex] != leftRoot) {
            leftRootIndex++;
        }
        int leftSize = leftRootIndex - postStart + 1;
        return new TreeNode(preorder[preStart], 
            ConstructHelper(preorder, preStart + 1, preStart + leftSize, postorder, postStart, leftRootIndex), 
            ConstructHelper(preorder, preStart + leftSize + 1, preEnd, postorder, leftRootIndex + 1, postEnd - 1));
    }
}
