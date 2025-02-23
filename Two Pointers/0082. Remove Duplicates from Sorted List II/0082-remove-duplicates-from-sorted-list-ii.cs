namespace LeetCodeSolutions.TwoPointers;

/*
 * 0082. Remove Duplicates from Sorted List II
 * Difficulty: Medium
 * Submission Time: 2025-02-23 17:02:21
 * Created by vahtyah on 2025-02-23 17:02:42
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
    public ListNode DeleteDuplicates(ListNode head) {
        if (head == null || head.next == null) {
            return head;
        }
        
        var dummy = new ListNode(0, head);
        var prev = dummy;
        var curr = head;
        
        while (curr != null) {
            bool skipNode = false;
            while (curr.next != null && curr.val == curr.next.val) {
                skipNode = true;
                curr = curr.next;
            }
            if (skipNode) {
                prev.next = curr.next;
            } else {
                prev = prev.next;
            }
            curr = curr.next;
        }
        
        return dummy.next;
    }
}