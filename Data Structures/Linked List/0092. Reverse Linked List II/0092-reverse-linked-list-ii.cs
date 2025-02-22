namespace LeetCodeSolutions.DataStructures/LinkedList;

/*
 * 0092. Reverse Linked List II
 * Difficulty: Medium
 * Submission Time: 2025-02-22 18:40:11
 * Created by vahtyah on 2025-02-22 18:40:30
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
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        if (head == null || left == right) return head;
        
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        ListNode prev = dummy;
        
        for (int i = 1; i < left; i++) {
            prev = prev.next;
        }
        
        ListNode current = prev.next;
        ListNode next = null;
        
        //In-place Reversal Technique
        for (int i = 0; i < right - left; i++) {
            next = current.next;
            current.next = next.next;
            next.next = prev.next;
            prev.next = next;
        }
        
        return dummy.next;
    }
}