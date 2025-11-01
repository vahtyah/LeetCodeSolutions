namespace LeetCodeSolutions.DataStructures/HashTable;

/*
 * 3217. Delete Nodes From Linked List Present in Array
 * Difficulty: Medium
 * Submission Time: 2025-11-01 15:09:46
 * Created by vahtyah on 2025-11-01 15:12:07
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
    public ListNode ModifiedList(int[] nums, ListNode head) {
        Span<bool> seen = stackalloc bool[100001];

        foreach(var num in nums) seen[num] = true;

        while(head != null && seen[head.val]) head = head.next;

        var prev = head;
        var curr = head.next;

        while(curr != null){
            if(seen[curr.val])
                prev.next = curr.next;
            else
                prev = curr;
            curr = curr.next;
        }

        return head;
    }
}