namespace LeetCodeSolutions.DataStructures/Stack;

/*
 * 0173. Binary Search Tree Iterator
 * Difficulty: Medium
 * Submission Time: 2025-02-28 15:49:26
 * Created by vahtyah on 2025-02-28 15:56:30
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
public class BSTIterator {
    private Stack<TreeNode> stack;
    
    public BSTIterator(TreeNode root) {
        stack = new Stack<TreeNode>();
        PushAllLeft(root);
    }
    
    private void PushAllLeft(TreeNode node) {
        while (node != null) {
            stack.Push(node);
            node = node.left;
        }
    }
    
    public int Next() {
        TreeNode current = stack.Pop();
        
        if (current.right != null) {
            PushAllLeft(current.right);
        }
        
        return current.val;
    }
    
    public bool HasNext() {
        return stack.Count > 0;
    }
}

/**
 * Your BSTIterator object will be instantiated and called as such:
 * BSTIterator obj = new BSTIterator(root);
 * int param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */