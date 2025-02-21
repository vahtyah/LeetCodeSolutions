namespace LeetCodeSolutions.TwoPointers;

/*
 * 0141. Linked List Cycle
 * Difficulty: Easy
 * Submission Time: 2025-02-21 19:51:44
 * Created by vahtyah on 2025-02-21 19:52:05
*/
 
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
using System.Runtime.CompilerServices;
public class Solution {
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool HasCycle(ListNode head) {
        if (head == null || head.next == null || head.next.next == null || head.next.next.next == null) {
            return false;
        }
        
        var slow = head;
        var fast = head.next;
        
        while (fast != null && fast.next != null) {
            if (slow == fast) {
                return true;
            }
            
            slow = slow.next;
            fast = fast.next.next;
        }
        
        return false;
    }
}