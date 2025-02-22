namespace LeetCodeSolutions.Searching/Depth-FirstSearch;

/*
 * 1028. Recover a Tree From Preorder Traversal
 * Difficulty: Hard
 * Submission Time: 2025-02-22 06:46:24
 * Created by vahtyah on 2025-02-22 06:48:01
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

//Faster using Stack: https://github.com/vahtyah/LeetCodeSolutions/blob/57258671d377bbbaeeaed694fde0c458c74dee96/Data%20Structures/Stack/1028.%20Recover%20a%20Tree%20From%20Preorder%20Traversal

public class Solution {
    private int index = 0;
    
    public TreeNode RecoverFromPreorder(string traversal) {
        return DFS(traversal, 0);
    }
    
    private TreeNode DFS(string s, int depth) {
        int dashCount = 0;
        
        while (index + dashCount < s.Length && s[index + dashCount] == '-') {
            dashCount++;
        }
        
        if (dashCount != depth) {
            return null;
        }
        
        index += dashCount;
        
        int value = 0;
        while (index < s.Length && s[index] >= '0' && s[index] <= '9') {
            value = value * 10 + (s[index] - '0');
            index++;
        }
        
        TreeNode node = new TreeNode(value);
        
        TreeNode left = DFS(s, depth + 1);
        if (left != null) {
            node.left = left;
        }
        
        TreeNode right = DFS(s, depth + 1);
        if (right != null) {
            node.right = right;
        }
        
        return node;
    }
}