namespace LeetCodeSolutions.Recursion/DivideandConquer;

/*
 * 0023. Merge k Sorted Lists
 * Difficulty: Hard
 * Submission Time: 2025-06-11 06:21:21
 * Created by vahtyah on 2025-06-11 06:21:41
*/
 
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
*/

public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        if (lists.Length == 0) return null;
        return MergeKLists(lists, 0, lists.Length - 1);
    }

    private ListNode MergeKLists(ListNode[] lists, int left, int right) {
        if (left > right) return null;
        if (left == right) return lists[left];
        
        int mid = left + (right - left) / 2;
        var leftList = MergeKLists(lists, left, mid);
        var rightList = MergeKLists(lists, mid + 1, right);
        
        return Merge(leftList, rightList);
    }

    private ListNode Merge(ListNode left, ListNode right) {
        var dummy = new ListNode();
        var current = dummy;

        while (left != null && right != null) {
            if (left.val <= right.val) {
                current.next = left;
                left = left.next;
            } else {
                current.next = right;
                right = right.next;
            }
            current = current.next;
        }

        current.next = left ?? right;

        return dummy.next;
    }
}