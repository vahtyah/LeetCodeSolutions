namespace LeetCodeSolutions.Searching/Breadth-FirstSearch;

/*
 * 0100. Same Tree
 * Difficulty: Easy
 * Submission Time: 2025-02-23 13:38:42
 * Created by vahtyah on 2025-02-23 13:44:22
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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if (p == q) return true;
        if (p == null || q == null) return false;
        
        Queue<TreeNode> q1 = new(), q2 = new();
        q1.Enqueue(p);
        q2.Enqueue(q);
        
        while (q1.Count > 0) {
            p = q1.Dequeue();
            q = q2.Dequeue();
            
            if (p.val != q.val) return false;
            
            if ((p.left == null) != (q.left == null)) return false;
            if ((p.right == null) != (q.right == null)) return false;
            
            if (p.left != null) {
                q1.Enqueue(p.left);
                q2.Enqueue(q.left);
            }
            if (p.right != null) {
                q1.Enqueue(p.right);
                q2.Enqueue(q.right);
            }
        }
        return true;
    }
}