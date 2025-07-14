namespace LeetCodeSolutions.DataStructures/LinkedList;

/*
 * 1290. Convert Binary Number in a Linked List to Integer
 * Difficulty: Easy
 * Submission Time: 2025-07-14 05:35:37
 * Created by vahtyah on 2025-07-14 05:38:44
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
    public int GetDecimalValue(ListNode head) {
        int result = 0;
        while (head != null) {
            result = (result << 1) | head.val;
            head = head.next;
        }
        return result;
    }
}