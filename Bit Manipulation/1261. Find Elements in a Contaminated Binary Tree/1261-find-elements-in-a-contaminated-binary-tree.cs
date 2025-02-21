namespace LeetCodeSolutions.BitManipulation;

/*
 * 1261. Find Elements in a Contaminated Binary Tree
 * Difficulty: Medium
 * Submission Time: 2025-02-21 05:54:13
 * Created by vahtyah on 2025-02-21 06:07:41
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
public class FindElements {
    private readonly TreeNode root;
    public FindElements(TreeNode root) {
        this.root = root;
    }
    
    public bool Find(int target) {
        TreeNode current = root;
        //0 means go left, 1 means go right
        int mask = HighestOneBit(target + 1) >> 1;
        
        while (mask > 0 && current != null) {
            current = ((target + 1) & mask) == 0 ? current.left : current.right;
            mask >>= 1;
        }
        
        return current != null;
    }

    private static int HighestOneBit(int i) {
        i |= (i >>  1);
        i |= (i >>  2);
        i |= (i >>  4);
        i |= (i >>  8);
        i |= (i >> 16);
        return i - (i >> 1);
    }
}

/**
 * Your FindElements object will be instantiated and called as such:
 * FindElements obj = new FindElements(root);
 * bool param_1 = obj.Find(target);
 */