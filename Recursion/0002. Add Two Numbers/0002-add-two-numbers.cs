namespace LeetCodeSolutions.Recursion;

/*
 * 0002. Add Two Numbers
 * Difficulty: Medium
 * Submission Time: 2025-02-22 10:17:07
 * Created by vahtyah on 2025-02-22 10:28:48
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
public class Solution 
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2, int carry = 0) 
    {
        if(l1 == null && l2 == null && carry == 0) return null;

        int total = (l1?.val ?? 0) + (l2?.val ?? 0) + carry;
        carry = total / 10;
        return new ListNode(total % 10,  AddTwoNumbers(l1?.next, l2?.next, carry));
    }
}