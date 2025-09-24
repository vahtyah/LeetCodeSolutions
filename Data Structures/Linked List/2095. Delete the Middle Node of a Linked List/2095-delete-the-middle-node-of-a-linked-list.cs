namespace LeetCodeSolutions.DataStructures/LinkedList;

/*
 * 2095. Delete the Middle Node of a Linked List
 * Difficulty: Medium
 * Submission Time: 2026-06-15 02:54:12
 * Created by vahtyah on 2026-06-15 02:54:50
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
    public ListNode DeleteMiddle(ListNode head) {
        if(head.next == null) return null;

        var slow = head;
        var fast = head;
        var prev = head;

        while(fast != null && fast.next != null){
            prev = slow;
            slow = slow.next;
            fast = fast.next.next;
        }

        prev.next = slow.next;
        
        return head;
    }
}