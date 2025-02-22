namespace LeetCodeSolutions.TwoPointers;

/*
 * 0019. Remove Nth Node From End of List
 * Difficulty: Medium
 * Submission Time: 2025-02-22 20:18:27
 * Created by vahtyah on 2025-02-22 20:19:01
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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        if (head == null) return null;
        
        var dummy = new ListNode(0, head);
        var slow = dummy;
        var fast = dummy;
        
        for (int i = 0; i <= n; i++) {
            fast = fast.next;
        }
        
        while (fast != null) {
            slow = slow.next;
            fast = fast.next;
        }
        
        slow.next = slow.next.next;
        
        return dummy.next;
    }
}