namespace LeetCodeSolutions.Sorting/MergeSort;

/*
 * 0148. Sort List
 * Difficulty: Medium
 * Submission Time: 2025-06-07 15:15:14
 * Created by vahtyah on 2025-06-07 15:15:35
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
    public ListNode SortList(ListNode head) {
        if (head == null || head.next == null) return head;
        
        var length = GetLength(head);
        
        var dummy = new ListNode(0);
        dummy.next = head;

        //Bottom-Up Merge Sort
        for (int step = 1; step < length; step *= 2) {
            ListNode prev = dummy;
            ListNode curr = dummy.next;
            
            while (curr != null) {
                ListNode left = curr;
                ListNode right = Split(left, step);
                curr = Split(right, step);
                
                prev = Merge(left, right, prev);
            }
        }
        
        return dummy.next;
    }
    
    private int GetLength(ListNode head) {
        int length = 0;
        for (var node = head; node != null; node = node.next) {
            length++;
        }
        return length;
    }
    
    private ListNode Split(ListNode head, int step) {
        if (head == null) return null;
        
        for (int i = 1; i < step && head.next != null; i++) {
            head = head.next;
        }
        
        ListNode right = head.next;
        head.next = null;
        return right;
    }
    
    private ListNode Merge(ListNode left, ListNode right, ListNode prev) {
        ListNode curr = prev;
        
        while (left != null && right != null) {
            if (left.val <= right.val) {
                curr.next = left;
                left = left.next;
            } else {
                curr.next = right;
                right = right.next;
            }
            curr = curr.next;
        }
        
        curr.next = left ?? right;
        
        while (curr.next != null) {
            curr = curr.next;
        }
        
        return curr;
    }
}