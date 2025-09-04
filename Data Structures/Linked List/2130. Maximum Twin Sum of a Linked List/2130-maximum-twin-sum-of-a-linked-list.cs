namespace LeetCodeSolutions.DataStructures/LinkedList;

/*
 * 2130. Maximum Twin Sum of a Linked List
 * Difficulty: Medium
 * Submission Time: 2026-06-14 03:34:52
 * Created by vahtyah on 2026-06-14 03:35:09
*/
 
public class Solution {
    public int PairSum(ListNode head) {
        ListNode prev = null;
        ListNode slow = head;
        ListNode fast = head;

        while (fast != null && fast.next != null)
        {
            fast = fast.next.next;

            ListNode next = slow.next;
            slow.next = prev;
            prev = slow;
            slow = next;
        }

        int maxSum = 0;

        while (prev != null && slow != null)
        {
            maxSum = Math.Max(maxSum, prev.val + slow.val);

            prev = prev.next;
            slow = slow.next;
        }

        return maxSum;
    }
}