namespace LeetCodeSolutions.Recursion/NonTailRecursion;

/*
 * 0021. Merge Two Sorted Lists
 * Difficulty: Easy
 * Submission Time: 2025-02-22 10:51:28
 * Created by vahtyah on 2025-03-01 07:51:04
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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if (list1 == null) return list2;  
        if (list2 == null) return list1;  
        
        if (list1.val <= list2.val) {
            list1.next = MergeTwoLists(list1.next, list2);
            return list1;
        } else {
            list2.next = MergeTwoLists(list1, list2.next);
            return list2;
        }
    }
}