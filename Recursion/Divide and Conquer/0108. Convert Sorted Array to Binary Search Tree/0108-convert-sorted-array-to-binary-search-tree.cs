namespace LeetCodeSolutions.Recursion/DivideandConquer;

/*
 * 0108. Convert Sorted Array to Binary Search Tree
 * Difficulty: Easy
 * Submission Time: 2025-06-07 08:13:43
 * Created by vahtyah on 2025-06-07 08:14:00
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
    public TreeNode SortedArrayToBST(int[] nums) {
        return BuildBST(nums, 0, nums.Length - 1);
    }
    
    private TreeNode BuildBST(int[] nums, int left, int right) {
        if (left > right) return null;
        
        int mid = left + (right - left) / 2;
        return new TreeNode(nums[mid], BuildBST(nums, left, mid - 1), BuildBST(nums, mid + 1, right));
    }
}