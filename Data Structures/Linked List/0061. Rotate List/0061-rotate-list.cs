namespace LeetCodeSolutions.DataStructures/LinkedList;

/*
 * 0061. Rotate List
 * Difficulty: Medium
 * Submission Time: 2025-02-23 12:35:50
 * Created by vahtyah on 2025-02-23 12:36:13
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
    public ListNode RotateRight(ListNode head, int k) {
        if (head == null || head.next == null || k == 0)
            return head;
        var nodes = new ListNode[501];
        var len = 0;

        while(head != null){
            nodes[len++] = head;
            head = head.next;
        }

        var firstIdx = (len - k % len) % len;
        if(firstIdx == 0) return nodes[0];

        nodes[len - 1].next = nodes[0];
        nodes[firstIdx - 1].next = null; 

        return nodes[firstIdx];
    }
}