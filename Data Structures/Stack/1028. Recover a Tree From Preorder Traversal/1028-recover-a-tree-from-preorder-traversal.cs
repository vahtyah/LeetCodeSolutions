namespace LeetCodeSolutions.DataStructures/Stack;

/*
 * 1028. Recover a Tree From Preorder Traversal
 * Difficulty: Hard
 * Submission Time: 2025-02-22 06:46:24
 * Created by vahtyah on 2025-02-22 06:46:44
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
    public TreeNode? RecoverFromPreorder(string traversal) {
        var index = 0;
        var stack = new TreeNode[1002];
        var top = -1;

        while (index < traversal.Length)
        {
            var dash = 0;
            while (traversal[index] == '-')
            {
                dash++;
                index++;
            }

            var value = 0;
            while (index < traversal.Length && char.IsAsciiDigit(traversal[index]))
            {
                value = value * 10 + (traversal[index] - '0');
                index++;
            }

            while (top + 1 > dash)
            {
                top--;
            }
            
            var child = new TreeNode(value);
            if (top != -1)
            {
                var parent = stack[top];
                if (parent.left == null)
                {
                    parent.left = child;
                }
                else if (child.right == null)
                {
                    parent.right = child;
                }
            }
            
            stack[++top] = child;
        }

        return stack[0];
    }
}