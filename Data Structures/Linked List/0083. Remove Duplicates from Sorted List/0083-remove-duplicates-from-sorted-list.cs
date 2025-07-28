namespace LeetCodeSolutions.DataStructures/LinkedList;

/*
 * 0083. Remove Duplicates from Sorted List
 * Difficulty: Easy
 * Submission Time: 2025-09-01 12:35:47
 * Created by vahtyah on 2025-09-01 12:44:27
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
        var prev = head;
        var curr = head?.next;

        while(curr != null){
            if(curr.val == prev.val){
                prev.next = curr.next;
                curr = prev.next;
                continue;
            }
            
            prev = curr;
            curr = curr.next;
        }

        return head;
    }
}