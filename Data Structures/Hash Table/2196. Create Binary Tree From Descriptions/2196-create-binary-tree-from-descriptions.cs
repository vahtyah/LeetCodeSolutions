namespace LeetCodeSolutions.DataStructures/HashTable;

/*
 * 2196. Create Binary Tree From Descriptions
 * Difficulty: Medium
 * Submission Time: 2026-06-07 08:45:47
 * Created by vahtyah on 2026-06-08 06:16:19
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
    public TreeNode CreateBinaryTree(int[][] descriptions) {
        var n = descriptions.Length;
        var nodes = new Dictionary<int, TreeNode>(2 * n);
        var hasChildren = new bool[100001];

        for(int i = 0; i < descriptions.Length; i++){
            var parent = descriptions[i][0];
            var child = descriptions[i][1];
            var isLeft = descriptions[i][2] == 1;

            if(!nodes.TryGetValue(parent , out var p)){
                p = new TreeNode(parent);
                nodes.Add(parent, p);
            }

            if(!nodes.TryGetValue(child, out var c)){
                c = new TreeNode(child);
                nodes.Add(child, c);
            }

            if(isLeft) p.left = c;
            else p.right = c;

            hasChildren[child] = true;
        }

        for(int i = 0; i < n; i++){
            var parent = descriptions[i][0];
            if(hasChildren[parent]) continue;
            return nodes[parent];
        }

        return null;
    }
}