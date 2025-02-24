namespace LeetCodeSolutions.TwoPointers;

/*
 * 0086. Partition List
 * Difficulty: Medium
 * Submission Time: 2025-02-24 06:29:06
 * Created by vahtyah on 2025-02-24 06:29:57
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
    public ListNode Partition(ListNode head, int x) {
        ListNode beforeHead = new ListNode(0);
        ListNode afterHead = new ListNode(0);
        
        ListNode before = beforeHead;
        ListNode after = afterHead;
        
        while (head != null) {
            if (head.val < x) {
                before.next = head;
                before = before.next;
            } else {
                after.next = head;
                after = after.next;
            }
            head = head.next;
        }
        
        after.next = null;  
        before.next = afterHead.next;
        
        return beforeHead.next;
    }
}